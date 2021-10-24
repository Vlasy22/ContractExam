Steps taken/planned
1. Database structure design - see ER diagram at https://dbdiagram.io/d/617572766239e146477fd8db
2. Creating repository, database project and console project
3. Creating database on local, Creating INSERTs for enums (like Currency...)
4. a) Choose right way to process xml - must have is loading large - 50gb files - definitely need to use SAX parser
4. b) Choosing .NET native XmlReader
5. Test XmlReader for few examples - creating sample xml
6. Generating classes according to provided xsd
7.  Define solution for the process:
	Loading defined sub-batch size of contracts (10000 for example) in batch via XmlParser - is needed to test best performance ratio between memory usage and speed
	Transform these 10000 IEnumerable<XElement> into generated classes
	Generate SQL queries for inserting these 10 000 contract elements - with use of NuGet package EntityFramework.Utilities.Denis - already tested, fast for large batches of data
		Now the question if it is just for import, or the individuals can be already stored at the database, so no need to import these data (only update)
		Query order is based on foreign key constraints - for example first start with Contract, then Individuals and after that we can import into ContractXSubject

8. After few successful end to end imports creating Indexes on tables






How to replicate:
1. In database project ContractExamDB build and publish - you need to edit publish profile to match your desired database server
2. IN MS SQL Management Studio open and exexute sql script - INSERT for enums
3. You can see ER diagram at https://dbdiagram.io/d/617572766239e146477fd8db
4. Open project ContractExamService - not so much to see, I have tested the XmlReader and generated classes from xsd, but I had already too little time to finish. See Steps taken/planned.