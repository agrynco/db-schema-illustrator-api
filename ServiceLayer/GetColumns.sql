SELECT *
FROM (SELECT mytable.TABLE_SCHEMA,
             mytable.TABLE_NAME,
             mytable.COLUMN_NAME,
             CASE
                 WHEN mytable.COLUMN_NAME IN (SELECT COLUMN_NAME
                                              FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE
                                              WHERE OBJECTPROPERTY(OBJECT_ID(constraint_name), 'IsPrimaryKey') = 1
                                                AND table_name = mytable.TABLE_NAME
                                                AND table_schema = mytable.TABLE_SCHEMA) THEN 'Yes'
                 ELSE 'No'
                 END AS IsPrimaryKey
      FROM INFORMATION_SCHEMA.COLUMNS mytable
               JOIN INFORMATION_SCHEMA.TABLES mytables
                    ON mytable.TABLE_NAME = mytables.TABLE_NAME and mytable.TABLE_SCHEMA = mytables.TABLE_SCHEMA
      WHERE mytables.TABLE_TYPE = 'BASE TABLE') T
WHERE TABLE_SCHEMA = @schemaName;