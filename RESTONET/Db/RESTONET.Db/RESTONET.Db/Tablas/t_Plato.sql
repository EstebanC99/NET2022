CREATE TABLE [dbo].[t_Plato]
(
	[ID_Plato]          INT         NOT NULL , 
    [Descripcion]       VARCHAR(50) NOT NULL, 
    [ID_TipoPlato]      INT         NOT NULL, 
    [ID_PrecioPlato]    INT         NOT NULL, 
    CONSTRAINT [PK_t_Plato] PRIMARY KEY ([ID_Plato]),
    CONSTRAINT [FK_t_TipoPlato_t_Plato] FOREIGN KEY (ID_TipoPlato) REFERENCES [dbo].[t_TipoPlato](ID_TipoPlato),
    CONSTRAINT [FK_t_PrecioPlato_t_Plato] FOREIGN KEY (ID_PrecioPlato) REFERENCES [dbo].[t_PrecioPlato](ID_PrecioPlato)
)
