# BugTracker
Created: Aug 15, 2022\
Status: Staging/Outlining\
Type: CodeSample\
Author: James Petko (Petko.James@gmail.com)

### Summary

Windows Presentation Foundation app using MVVM design method. Solution to feature different projects. A Server side service that will monitor for report submissions and push notifications to their desired users.
	The other component will be for user generated submissions. a WPF applicaiton using MVVM design structure to gather the desired information. The application in this case will have a hardcoded destination but in deplotment this can be replaced with either an argument or setting.xml file.

### Configuration
Server side configuration includes setting the product line/name and setting which email addresses should have notifications pushed to them.
Client side will require no additional configuration.

### Non-Goals
This application is not designed to serve as a replacement for an integrated bug reporting module. it should only serve as a code reference.

### Proposed Solution
Application will generate an fdf file that will be pushed to a server. The server will have an application to parse the fdf into a pdf document. This will also generate a notification for submitted users/emails. If no email is available or otherwise doesn't exist, the application will parse the fdf into a .log file and save locally on the server.

### Open Questions
##### Is It secure?

##### What Platforms are supported?
The Client and server are intended to operate on windows based products.

##### Does an application need to be open on the server?
The server will use a linked service to monitor for new submissions and parse them accordingly. The service will also require tha the fdf have a valid email(s) for the bug report to be sent to.

##### How ofter are notifications pushed?
Notifications will be pushed once daily with a summary of all submissions including those that failed to email. This setting might be available during the configuration process.

### How To Run the Sample
TBD
### Alternatives to Consider
Transparent tracking, allow the user to submit an email AND push the report to the engineering team members