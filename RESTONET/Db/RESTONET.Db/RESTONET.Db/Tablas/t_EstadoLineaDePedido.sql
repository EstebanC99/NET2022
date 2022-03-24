CREATE TABLE [dbo].[t_EstadoLineaDePedido]
(
	[ID_EstadoLineaDePedido]            INT         NOT NULL , 
    [Descripcion]                       VARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_t_EstadoLineaDePedido] PRIMARY KEY ([ID_EstadoLineaDePedido])
)
