# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project

"Thrifty" is a monthly spending tracker. Amounts are in Singapore dollars (`S$`), and merchants and payment methods are SG-specific (PayNow, GIRO, NTUC). The repo has two top-level folders:

- `Frontend/`: React 19 + TypeScript + Vite SPA. Every page still reads static data from `Frontend/src/data/mockData.ts`; it is not yet wired to the API.
- `Backend/`: ASP.NET Core (.NET 10) Web API with EF Core + SQLite, solution `Backend/Thrifty.slnx`.

## Commands

Run these from `Frontend/`:

```bash
npm run dev       # Vite dev server with HMR
npm run build     # tsc -b (type-check) then vite build
npm run lint      # oxlint (react, typescript, oxc plugins)
npm run preview   # serve the production build
```

Run these from `Backend/`:

```bash
dotnet build Thrifty.slnx
dotnet run --project src/Thrifty.Api          # http://localhost:5236, GET /api/transactions
dotnet tool restore                           # installs dotnet-ef from dotnet-tools.json
dotnet dotnet-ef migrations add <Name> --project src/Thrifty.Infrastructure --startup-project src/Thrifty.Api --output-dir Persistence/Migrations
```

There are no tests in either project. Verify changes with:

- Frontend: `npm run build` is the type-check gate. `tsconfig.app.json` sets `noUnusedLocals` and `noUnusedParameters`, so unused code fails the build.
- Backend: `dotnet build Thrifty.slnx`. Nullable reference types are enabled but warnings do not fail the build, so read the output.

In Development, the API serves its OpenAPI spec at `/openapi/v1.json` (JSON only, no Swagger UI). `src/Thrifty.Api/Thrifty.Api.http` holds ready-to-run requests; add one for each new endpoint.

## Architecture

- **Routing:** `App.tsx` wraps every route in `AppShell` (NavBar + main content). The four pages in `src/pages/` map to `/`, `/transactions`, `/budgets` and `/reports`.
- **Component layers:**
  - `components/ui/`: generic, domain-agnostic primitives (Button, Card, Tabs, Pagination, and so on).
  - `components/data/`: domain components that take typed finance data (Transaction, BudgetCategory, …). The charts here wrap Recharts.
  - `components/layout/`: the app shell and navigation.
- **Data model:** all domain types live in `src/types/index.ts`. `Transaction.amount` is signed: negative means expense, positive means income. Filter on the sign rather than on category when separating the two.
- **Mock data:** `src/data/mockData.ts` exports `categories`, `transactions`, `budgets`, `dailySpend`, `monthlySpend`, `categoryChanges` and `summary`. Pages import from it directly. When a backend is added, this is the seam to replace.
- **Categories and colors:** `CategoryId` is a fixed union. Each entry in `categories` has a `colorVar` that names a CSS custom property (e.g. `'--color-food'`). Components apply it as `` `var(${cat.colorVar})` ``, including as Recharts `fill`. Adding a category means updating the `CategoryId` union, the `categories` map, a matching `--color-*` token in `tokens.css`, and the backend `CategoryId` enum in `Thrifty.Domain/Enums/`. `BudgetStatus` is mirrored the same way.

## Backend architecture

Clean Architecture, one project per layer under `Backend/src/`. References point inward only: `Api → Infrastructure → Application → Domain`.

- **Thrifty.Domain:** entities (`Transaction`, `Budget`) and enums. No dependencies, no EF or JSON attributes.
- **Thrifty.Application:** services, DTOs, and repository interfaces in `Abstractions/`. Never references EF Core.
- **Thrifty.Infrastructure:** `AppDbContext`, `IEntityTypeConfiguration` classes, migrations, seed data, repository implementations.
- **Thrifty.Api:** controllers and `Program.cs` only. Controllers call Application services, never the `DbContext`.

Conventions:
- Money is `decimal` in C# and stored as integer cents via `MoneyConverter`, because SQLite cannot aggregate decimals.
- Only `Transactions` and `Budgets` are stored. Budget spent/status, summaries and chart series are computed, not persisted.
- Enums serialize as kebab-case strings (`"food"`, `"on-track"`) to match the frontend's TS unions.
- Category is stored as the enum name string (e.g. `"Food"`). Adding a value needs no migration, but renaming one orphans existing rows.
- In Development, pending migrations are applied at startup. The SQLite file is `src/Thrifty.Api/thrifty.db` and is gitignored. To reset it, stop the API and delete `thrifty.db*`; the next run recreates it.
- The frontend is not wired to the API yet: there is no CORS policy in `Program.cs` and no proxy in `vite.config.ts`. One of them is needed before the first fetch from the Vite dev server.

## Styling

- Every component has its own co-located `*.module.css` (CSS Modules). No CSS framework is used.
- Design tokens (colors, `--space-1`…`--space-6`, `--radius-*`) are defined in `src/styles/tokens.css`, which is imported globally in `main.tsx`. Use the tokens instead of hard-coded values.
