MERGE t_EstadoLineaDePedido t
USING
(
	SELECT *
	FROM
	(
		VALUES
		(1, 'Pedido'),
		(2, 'En Preparacion'),
		(3, 'Listo'),
		(4, 'Entregado')
	) i (ID_EstadoLineaDePedido, Descripcion)
) ii ON (ii.ID_EstadoLineaDePedido = t.ID_EstadoLineaDePedido)
WHEN MATCHED THEN UPDATE SET
	t.Descripcion = ii.Descripcion
WHEN NOT MATCHED BY TARGET THEN INSERT
	(ID_EstadoLineaDePedido, Descripcion)
	VALUES
	(ii.ID_EstadoLineaDePedido, Descripcion);
