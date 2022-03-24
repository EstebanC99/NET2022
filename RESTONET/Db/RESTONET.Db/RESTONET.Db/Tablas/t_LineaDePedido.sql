CREATE TABLE [dbo].[t_LineaDePedido]
(
	[ID_LineaDePedido]      INT             NOT NULL , 
    [Cantidad]              INT             NULL, 
    [Observacion]           VARCHAR(250)    NULL, 
    [ID_Pedido]             INT             NOT NULL, 
    [ID_Plato]              INT             NOT NULL, 
    [ID_EstadoLineaDePedido] INT            NOT NULL, 
    CONSTRAINT [PK_t_LineaDePedido] PRIMARY KEY ([ID_LineaDePedido]),
    CONSTRAINT [FK_t_Plato_t_LineaDePedido] FOREIGN KEY (ID_Plato) REFERENCES [dbo].[t_Plato](ID_Plato),
    CONSTRAINT [FK_t_EstadoLineaDePedido] FOREIGN KEY (ID_EstadoLineaDePedido) REFERENCES [dbo].[t_EstadoLineaDePedido](ID_EstadoLineaDePedido)
)
