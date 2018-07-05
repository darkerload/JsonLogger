## JsonLogger

This library providing logger to text file. You can use easily for all .net apps.

### How do I implementation?

You can add reference from "JsonLogger.Core" to your own project

### Usage

```csharp
 static void Main(string[] args)
        {
            //First of all, you need define log name like "connection, network" as below example when creating object of Logger
            var log = new Logger("connection");
            //You can giving 2 parameter when writing to log
            log.Write("test", NotifyType.Error);
            //Even you are using parallel etc. You can use below ex:
            Parallel.For(0, 20, i =>
            {
                log.Write("test : " + i.ToString(), NotifyType.Warning);
            });
        }
 ```
 
 ### Features
 * You can set settings from a config file
 * Define notify type
 * Thread safe
 
 ### Configuration
 
 ``` json
{
    "settings": {
        "log": [
            {
                "name": "network",
                "allow": "*"
            },
            {
                "name": "connection",
                "allow": "Error,Information"
            }
        ]
    }
}
```
 
