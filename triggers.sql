/*
SELECT  
    name,
    is_instead_of_trigger
FROM 
    sys.triggers  
WHERE 
    type = 'TR';
*/




SELECT 
	t2.[name] TableTriggerReference
	, SCHEMA_NAME(t2.[schema_id]) TableSchemaName
	, t1.[name] TriggerName
	, t1.is_disabled
FROM sys.triggers t1
	INNER JOIN sys.tables t2 ON t2.object_id = t1.parent_id
WHERE 1=1
--and t1.is_disabled = 0
	--AND t1.is_ms_shipped = 0
	--AND t1.parent_class = 1

