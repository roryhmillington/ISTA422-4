ISTA 422-4 Azure Homework

Rory H. Millington

19 June 2018

1.What is the target of Azure SQL Databases.

	SQL Database is a general-purpose relational database managed service in Microsoft Azure that supports structures such as relational data, JSON, spatial, and XML. SQL Database offers managed single SQL databases, managed SQL databases in an elastic pool, and SQL Managed Instances (in public preview). It delivers dynamically scalable performance within two different purchasing models (DTU-based purchasing model and vCore-based purchasing model (preview).

2.By default, how many logical SQL 

	20

3.Why does the connection string set the TrustServerCertiﬁcate property to False and the Encrypt property to True?

	The Microsoft JDBC Driver for SQL Server or client has to validate that the server is the correct server and its certificate is issued by a certificate authority that the client trusts. In order to validate the server certificate, the trust material must be supplied at connection time. In addition, the issuer of the server certificate must be a certificate authority that the client trust

3.What are transient errors?

--A transient error, also known as a transient fault, has an underlying cause that soon resolves itself. An occasional cause of transient errors is when the Azure system quickly shifts hardware resources to better load-balance various workloads. Most of these reconfiguration events finish in less than 60 seconds. During this reconfiguration time span, you might have connectivity issues to SQL Database.

4.What three things contribute to the total cost for running a SQL Server deployment on Azure Virtual Machines?

	Storage, transactions, bandwidth

5.Why do you need to be concerned about high availability and disaster recovery for SQL Server in Azure Virtual Machines?

	Microsoft Azure virtual machines (VMs) with SQL Server can help lower the cost of a high availability and disaster recovery (HADR) database solution. Most SQL Server HADR solutions are supported in Azure virtual machines, both as Azure-only and as hybrid solutions.

6.What are six SQL Server features that are not currently supported in SQL Database (according to the book)?

	restore, upgrade, encryption, ability to return result sets from triggers, table hints, remote servers

7.Name four factors to consider when choosing between SQL Database and SQL Server in Azure Virtual Machines.

	resources, total cost of ownership, business continuity, hybrid cloud

8.Who did Microsoft collaborate with to bring their ClearDb database as a service for MySQL to the Azure platform?

	ClearDB

9.What two options exist in Azure if you dont need a relational database management system (RDBMS)based data storage solution such as SQL Database or SQL Server in Azure Virtual Machines?

	Azure blob storage, Key/value databases