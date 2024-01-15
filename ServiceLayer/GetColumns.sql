SELECT *
FROM (SELECT mytable.TABLE_SCHEMA,
             mytable.TABLE_NAME,
             mytable.COLUMN_NAME,
             CASE
                 WHEN mytable.COLUMN_NAME IN (SELECT kcu.COLUMN_NAME
                                              FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS AS tc
                                                       JOIN INFORMATION_SCHEMA.KEY_COLUMN_USAGE AS kcu
                                                            ON tc.CONSTRAINT_NAME = kcu.CONSTRAINT_NAME
                                              WHERE tc.CONSTRAINT_TYPE = 'PRIMARY KEY'
                                                AND tc.TABLE_NAME = mytable.TABLE_NAME
                                                AND tc.TABLE_SCHEMA = mytable.TABLE_SCHEMA) THEN 'Yes'
                 ELSE 'No'
                 END AS IsPrimaryKey
      FROM INFORMATION_SCHEMA.COLUMNS mytable
               JOIN INFORMATION_SCHEMA.TABLES mytables
                    ON mytable.TABLE_NAME = mytables.TABLE_NAME and mytable.TABLE_SCHEMA = mytables.TABLE_SCHEMA
      WHERE mytables.TABLE_TYPE = 'BASE TABLE') T
WHERE TABLE_SCHEMA = @schemaName;