CREATE TABLE [dbo].[t_Mozo]
(
	[ID_Mozo]           INT         NOT NULL, 
    [Nombre]            VARCHAR(50) NOT NULL, 
    [Apellido]          VARCHAR(50) NOT NULL, 
    [DNI]               BIGINT      NOT NULL, 
    CONSTRAINT [PK_t_Mozo] PRIMARY KEY ([ID_Mozo]) 
)
