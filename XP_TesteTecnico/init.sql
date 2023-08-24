USE master;
CREATE DATABASE BDadosXP;

CREATE TABLE BDadosXP.dbo.Nome    ( NomeId       INT           NOT NULL   IDENTITY    ( 1,1        ),
						            NomeCompleto VARCHAR( 50 ) NOT NULL
												 CONSTRAINT PK_NomeId     PRIMARY KEY ( NomeId     ) )

CREATE TABLE BDadosXP.dbo.Telefone( TelefoneId   INT           NOT NULL   IDENTITY    ( 1,1        ),
									Telefone     VARCHAR( 50 ) NOT NULL 
												 CONSTRAINT PK_TelefoneId PRIMARY KEY ( TelefoneId ) )

CREATE TABLE BDadosXP.dbo.Email   ( EmailId      INT           NOT NULL   IDENTITY    ( 1,1        ),
									Email        VARCHAR( 50 ) NOT NULL 
												 CONSTRAINT PK_EmailId    PRIMARY KEY ( EmailId    ) )

CREATE TABLE BDadosXP.dbo.DadosCliente ( ClienteId  INT NOT NULL IDENTITY                ( 1, 1       ),
										 NomeId     INT NOT NULL REFERENCES Nome         ( NomeId     ), 
										 TelefoneId INT NOT NULL REFERENCES Telefone     ( TelefoneId ),
										 EmailId    INT NOT NULL REFERENCES Email        ( EmailId    )
                                                    CONSTRAINT PK_ClientelId PRIMARY KEY ( ClienteId  ) )