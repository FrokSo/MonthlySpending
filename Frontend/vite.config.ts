import react from '@vitejs/plugin-react'
import { defineConfig } from 'vite'

// https://vite.dev/config/
export default defineConfig({
  plugins: [react()],
  server: {
    // Forward API calls to the ASP.NET Core backend so the browser sees a single origin (no CORS needed).
    proxy: {
      '/api': 'http://localhost:5236',
    },
  },
})
