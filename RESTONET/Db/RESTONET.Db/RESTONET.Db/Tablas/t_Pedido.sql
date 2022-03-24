CREATE TABLE [dbo].[t_Pedido]
(
	[ID_Pedido]             INT         NOT NULL, 
    [NumeroDocumento]       VARCHAR(50) NOT NULL, 
    [ID_EstadoPedido]       INT         NOT NULL, 
    [ID_Mesa]               INT         NOT NULL, 
    [ID_Mozo]               INT         NOT NULL, 
    CONSTRAINT [PK_t_Pedido] PRIMARY KEY ([ID_Pedido]) ,
    CONSTRAINT [FK_t_EstadoPedido_t_Pedido] FOREIGN KEY (ID_EstadoPedido) REFERENCES [dbo].[t_EstadoPedido](ID_EstadoPedido),
    CONSTRAINT [FK_t_Mesa_t_Pedido] FOREIGN KEY (ID_Mesa) REFERENCES [dbo].[t_Mesa](ID_Mesa),
    CONSTRAINT [FK_t_Mozo_t_Pedido] FOREIGN KEY (ID_Mozo) REFERENCES [dbo].[t_Mozo](ID_Mozo)
)
