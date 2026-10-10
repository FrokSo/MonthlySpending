import { toIsoDate } from "../../utils/date";
import { useState } from "react";
import { categories } from "../../data/Categories";
import { paymentMethods } from "../../data/PaymentMethod";
import type { CategoryId, NewTransaction } from "../../types";
import Button from "../ui/Button";
import styles from "./AddTransactionForm.module.css";
import { createTransaction } from "../../api/transactions";
import {useTransactionsChanged} from "../../context/TransactionsContext";

interface AddTransactionFormProp{
    onSave: ()=>void;
    onCancel: () => void;

}


export default function AddTransactionForm({onSave, onCancel}:AddTransactionFormProp){
    const today = toIsoDate(new Date());
    const[date, setDate] = useState(today);
    const[merchant, setMerchant] = useState("");
    const[cost, setCost] = useState("");
    const[category, setCategory] = useState<CategoryId>("food");
    const[paymentMethod, setPaymentMethod] = useState("Credit card");
    const[note, setNote] = useState("");
    const {notifyChange} = useTransactionsChanged();
    const[saving, setSaving] = useState(false);

    async function handleSubmit(event: React.FormEvent<HTMLFormElement>){
        event.preventDefault();
        let newTransaction: NewTransaction;
        newTransaction = {
            amount: Number(-cost),
            category: category,
            date: date,
            merchant: merchant,
            paymentMethod: paymentMethod,
            note: note || undefined
        };
        try{
            if(saving === false)
            {
                setSaving(true);
                await createTransaction(newTransaction);
                notifyChange();
                onSave();
            }
        }
        catch(err: unknown){
            window.alert(`Couldn't add transaction: ${err instanceof Error ? err.message : String(err)}`);
        }        
        setSaving(false);
    }


    return(
        <div>
            <form className={styles.form} onSubmit={handleSubmit}>
                <label className={styles.field}>
                    Merchant:
                    <input className={styles.input} type="text" value={merchant} onChange={(e) => setMerchant(e.target.value)} required/>
                </label>
                <label className={styles.field}>Cost:
                    <input className={styles.input} type="number" value={cost} step="0.01" min="0.01"  onChange={(e) => setCost(e.target.value)} required/>
                </label>
                <label className={styles.field}>
                    Date:
                    <input className={styles.input} type="date" value={date} onChange={(e) => setDate(e.target.value)} required/>
                </label>
                <label className={styles.field}>
                    Category:
                    <select className={styles.input} value={category} onChange={(e) => setCategory(e.target.value as CategoryId)}>
                        {Object.values(categories)
                            .filter((c) => c.id !== 'income')
                            .map((c) => (
                            <option key={c.id} value={c.id}>
                                {c.label}
                            </option>
                        ))}
                    </select>
                </label>
                <label className={styles.field}>
                    Payment Method:
                    <select value={paymentMethod} className={styles.input} onChange={(e) => setPaymentMethod(e.target.value)}>
                        {Object.values(paymentMethods)
                            .map((p) => (
                                <option key={p} value={p}>
                                    {p}
                                </option>
                            ))}
                    </select>
                </label>
                <label className={styles.field}>
                    Note:
                    <input type="text" className={styles.input} placeholder="Notes" value={note} onChange={(e) => setNote(e.target.value)}/>
                </label>
                <div className={styles.actions}>
                    <Button type="button" variant="secondary" onClick={onCancel}>Cancel</Button>
                    <Button type="submit">Save</Button>
                </div>
            </form>
        </div>
    )
}