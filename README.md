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

### Appenders

Logging Event destinations:

- Application Event Log
- SQL Server database
- Local text file

Appenders - places where logging events go to be processed

Logging Event can be sent to all appenders, a subset or none.

### Configuration

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
			<file value="GuiAppLog.txt" />
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

### Log Levels

- All
- Debug
- Info
- Warn
- Error
- Fatal
- Off

### Logger Objects

Hierarchical

Appenders Accumulate

### Summary 

Create Logger objects using the GetLogger method of the LogManager class. 

ILog interface allows logging of raw objects, as well as format strings for logging. 

Conditional logging properties of this interface can bypass unnecessary expensive calculations during logging. 

Control logger verbosity by setting the level property of a logger to one of the severity levels defined by log4net.

These levels include ALL, DEBUG, INFO, WARN, ERROR, FATAL, and OFF. 

Logger object naming convention full name of the. NET type is used to define the logger for that type. 

These names translate into a logger hierarchy, and how you can use this logger hierarchy to configure the level and appenders for individual loggers. 

Attach individual appenders to specific loggers. 

Appenders accumulate across the logger hierarchy every time you log a message.

## Appenders

...

## References

[Application Instrumentation using log4net](https://app.pluralsight.com/library/courses/application-instrumentation-log4net/table-of-contents)

by Jim Christopher

Everything you need to know to start using log4net quickly and effectively.


