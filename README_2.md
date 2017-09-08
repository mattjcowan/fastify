

### My Benchmarks

__Machine:__ macOS Sierra V10.12.6 MacBook Pro (Retina, 15-inch, Late 2013) @ 2.3 GHz Intel Core i7, 16 GB 1600 MHz DDR3

__Method:__: `autocannon -c 100 -d 5 -p 10 localhost:3000` * 2

| Framework                 | Version                    | Router?      |  Requests/sec #1 |  Requests/sec #2 |
| :------------------------ | :------------------------- | :----------: | ---------------: | ---------------: |
| hapi                      | 16.5.0                     | &#10003;     | 4,029            | 4,438            |
| Express                   | 4.15.3                     | &#10003;     | 15,797           | 17,277           |
| Express (w/ midd.)        | 4.15.3                     | &#10003;     | 11,335           | 12,002           |
| Restify                   | 5.0.1                      | &#10003;     | 15,216           | 16,256           |
| take-five                 | 1.3.4                      | &#10003;     | 23,186           | 23,128           |
| Koa (`koa-router`)        | 2.3.0 (`koa-router@7.2.1`) | &#10003;     | 24,692           | 24,251           |
| Koa                       | 2.3.0                      | &#10007;     | 26,020           | 26,580           |
| **Fastify**               | **0.25.2**                 | **&#10003;** | **28,398**       | 28,430           |
| -                         |                            |              |                  |                  |
| `http.Server`             | 8.2.1                      | &#10007;     | 38,529           | 39,619           |
| -                         |                            |              |                  |                  |
| aspnet ss (fallback route)| dotnet core 2.0.0          | &#10003;     | 3,740            | 3,194            |
| aspnet ss (at /hello)     | dotnet core 2.0.0          | &#10003;     | 5,552            | 5,552            |
| aspnet ss (raw handler)   | dotnet core 2.0.0          | &#10003;     | 23,944           | 23,944           |
| aspnet webapi             | dotnet core 2.0.0          | **&#10003;** | **29,499**       | 31,238           |
| aspnet map                | dotnet core 2.0.0          | **&#10003;** | **48,950**       | 49,052           |
| aspnet raw w/ json.net    | dotnet core 2.0.0          | &#10007;     | 51,100           | 52,649           |
| aspnet raw w/ ss.text     | dotnet core 2.0.0          | &#10007;     | 52,534           | 51,939           |
