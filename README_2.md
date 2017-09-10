
### My Benchmarks

__Machine:__ macOS Sierra V10.12.6 MacBook Pro (Retina, 15-inch, Late 2013) @ 2.3 GHz Intel Core i7, 16 GB 1600 MHz DDR3

__Method:__: `autocannon -c 100 -d 60 -p 10 localhost:3000` * 2 (taking the average)

- Increased the time for each test to 60 seconds
- Some tests use special routes like: /hello or /greet/hello

| Framework | Router | Avg (req/sec) | StdDev | Max | 
| :------ | :-----: | -----: | -----: | -----: | 
| aspnet raw | &#10007; | 52592 | 2034 | 54015 | 
| aspnet map /hello | &#10003; | 51976 | 2481 | 55503 | 
| - | | | | | 
| webapi - sync | &#10003; | 33741 | 2287 | 35295 | 
| webapi - async | &#10003; | 31866 | 1821 | 33519 | 
| servicestack - fallback sync | &#10007; | 28722 | 1844 | 30495 | 
| servicestack - raw handler | &#10003; | 24176 | 2022 | 27007 | 
| servicestack - fallback async | &#10007; | 22089 | 1956 | 24471 | 
| servicestack - hello sync | &#10003; | 13293 | 1052 | 17263 | 
| servicestack - hello async | &#10003; | 12447 | 438 | 13263 | 
| - | | | | | 
| http.Server | &#10007; | 46900 | 1605 | 47983 | 
| - | | | | | 
| koa | &#10007; | 25958 | 1179 | 26599 | 
| koa-router | &#10003; | 23666 | 1131 | 24351 | 
| fastify | &#10003; | 22598 | 820 | 23911 | 
| take-five | &#10003; | 20659 | 563 | 21879 | 
| restify | &#10003; | 17851 | 470 | 18703 | 
| express | &#10003; | 17691 | 848 | 18231 | 
| express (w/ route prefix) | &#10003; | 15998 | 1040 | 16911 | 
| express (w/ middlewares) | &#10003; | 12902 | 578 | 13583 | 
| hapi.js | &#10003; | 4792 | 119 | 5051 |  
