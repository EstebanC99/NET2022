MERGE t_EstadoPedido t
USING
(
	SELECT *
	FROM
	(
		VALUES
		(1, 'Abierto'),
		(2, 'Cerrado')
	) i (ID_EstadoPedido, Descripcion)
) ii ON (ii.ID_EstadoPedido = t.ID_EstadoPedido)
WHEN MATCHED THEN UPDATE SET
	t.Descripcion = ii.Descripcion
WHEN NOT MATCHED BY TARGET THEN INSERT
	(ID_EstadoPedido, Descripcion)
	VALUES
	(ii.ID_EstadoPedido, Descripcion);

