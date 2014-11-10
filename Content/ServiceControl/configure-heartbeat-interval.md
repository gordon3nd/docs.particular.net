---
title: Heartbeat interval configuration
summary: Describes how to configure the ServiceControl Heartbeat plugin interval
tags:
- ServiceControl
- Hearthbeat
---

ServiceControl heartbeats are sent, by the plugin, at a predefined interval of 10 seconds. The interval value can be overridden on a per endpoint basis adding the following application setting to the endpoint configuration file:

```xml
<add key="heartbeat/interval" value="00:00:40" />
```

Where the value is convertible to a `TimeSpan` value. In the above sample you are setting the endpoint heartbeat interval to 40 seconds.

Note: to enable the change the endpoint needs to be restarted.

More on [ServiceControl Endpoint Plugins](/servicecontrol/plugins).