type Method = 'GET' | 'POST' | 'PUT' | 'DELETE';

// Paths are relative to /api, which the Vite dev server proxies to the backend.
async function request<T>(method: Method, path: string, body?: unknown, signal?: AbortSignal): Promise<T> {
  const response = await fetch(`/api${path}`, {
    method,
    signal,
    headers: body === undefined ? undefined : { 'Content-Type': 'application/json' },
    body: body === undefined ? undefined : JSON.stringify(body),
  });
  if (!response.ok) {
    throw new Error(`${method} ${path} failed with ${response.status}`);
  }
  // 204 No Content (typical for DELETE and some PUTs) has no body to parse.
  if (response.status === 204) {
    return undefined as T;
  }
  return (await response.json()) as T;
}

export function getJson<T>(path: string, signal?: AbortSignal): Promise<T> {
  return request<T>('GET', path, undefined, signal);
}

// Create: e.g. postJson<Transaction>('/transactions', newTransaction)
export function postJson<T>(path: string, body: unknown, signal?: AbortSignal): Promise<T> {
  return request<T>('POST', path, body, signal);
}

// Update: e.g. putJson<Transaction>(`/transactions/${id}`, changes)
export function putJson<T>(path: string, body: unknown, signal?: AbortSignal): Promise<T> {
  return request<T>('PUT', path, body, signal);
}

// Delete: e.g. deleteJson(`/transactions/${id}`)
export function deleteJson<T = void>(path: string, signal?: AbortSignal): Promise<T> {
  return request<T>('DELETE', path, undefined, signal);
}
