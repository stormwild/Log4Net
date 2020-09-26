# Log4Net

Learning Log4Net

## Pre-requisites

- log4net

## Set-up

Install through Nuget Package Manager. Using Package Manager Console, run the following:

```
Install-Package log4net
```

## Architecture

- Logger
- Logging Event
- Appenders
- Configuration

## Logger

```csharp
var log = LogManager.GetLogger(typeof(Program));
log.Info("This is a log message");
```

Whenever we log an object a log event is created.  

## Logging Event

Information associated with a Logging Event

- Context
- Thread
- Properties
- Severity
- Logger

## Appenders

Logging Event destinations:

- Application Event Log
- SQL Server database
- Local text file

Appenders - places where logging events go to be processed

Logging Event can be sent to all appenders, a subset or none.

## Configuration

The collection of appenders defined for your application as well as the rules that govern how logging events are routed is governed by the Configuration layer.

- Initial Log4Net with a configuration call

  - `log4net.Config.BasicConfigurator.Configure();`
  - `log4net.Config.XmlConfigurator.Configure();` 
  - `[assembly: log4net.Config.XmlConfigurator]`

- Make sure LEVEL is not OFF
- Check for configuration errors in the debugger output window of Visual Studio
- Set Layouts for Appenders that require them
- Apply appenders to loggers
- Log early

Sample Xml Configuration

`App.config` or `Web.config`

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
	<configSections>
		<section name="log4net" type="log4net.Config.Log4NetConfigurationSectionHandler, log4net" />
	</configSections>   
	<log4net>
		<appender name="Console" type="log4net.Appender.ConsoleAppender">
			<layout type="log4net.layout.SimpleLayout" />
		</appender>
		<!--<appender name="File" type="log4net.Appender.FileAppender">
			<layout type="log4net.layout.SimpleLayout" />
		</appender>-->
		<!-- Default Logger -->
		<root>
			<level value="ALL" />
			<!-- Appender reference must match the appender defined above -->
			<appender-ref ref="Console" />
		</root>
	</log4net>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.6.2" />
    </startup>
</configuration>
```

## References

[Application Instrumentation using log4net](https://app.pluralsight.com/library/courses/application-instrumentation-log4net/table-of-contents)

by Jim Christopher

Everything you need to know to start using log4net quickly and effectively.


