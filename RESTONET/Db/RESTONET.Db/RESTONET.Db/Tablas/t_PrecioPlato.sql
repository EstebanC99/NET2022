CREATE TABLE [dbo].[t_PrecioPlato]
(
	[ID_PrecioPlato]            INT             NOT NULL , 
    [Precio]                    NUMERIC(6, 2)   NOT NULL, 
    [FechaVigencia]             DATETIME        NOT NULL, 
    CONSTRAINT [PK_t_PrecioPlato] PRIMARY KEY ([ID_PrecioPlato])
)
