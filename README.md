# db-schema-illustrator-api

Task Specification
Given a database, you need to present all the entities which are related, and all the relations between them.
When a user hovers over a relation it gets the cardinality explanation for that relation

Required functionality
1. Show table names, with a background color different than the background of the key names.
2. Show key names
3. Lines describing relations and their direction between tables.
4. Tooltip with textual description of relations
Technical Requirements
In order to complete this task, you must use the following (all available for free online; any version is fine):
1. Development environment: Visual Studio
2. Database: AdventureWorks sample database. It must be renamed to “AdventureWorks” (if needed)
3. SQL Server: must be installed on the given server
4. For the data a soap web service must be created with a self-signed certificate on the given server
5. An ASP.NET project must run on your own computer, displaying the graph while communicating with
the SOAP web service built using SSL in order to retrieve the data.
6. The SOAP API must support exporting to PDF standalone
7. The api functions must all have a log writing an entry of start and end. The end entry must also have
a duration. The functions should not contain the logging code it must be only defined in one place.
