CREATE TABLE [dbo].[t_EstadoPedido]
(
	[ID_EstadoPedido]           INT         NOT NULL , 
    [Descripcion]               VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_t_EstadoPedido] PRIMARY KEY ([ID_EstadoPedido])
)
