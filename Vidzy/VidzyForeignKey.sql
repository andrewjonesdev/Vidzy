USE Vidzy;    
/*GO    
ALTER TABLE dbo.Genres    
ADD CONSTRAINT FK_Genres_Videos FOREIGN KEY (VideoId)     
    REFERENCES dbo.Videos (Id)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE    
;    
GO*/    
ALTER TABLE dbo.Videos    
ADD CONSTRAINT FK_Videos_Genres FOREIGN KEY (GenreId)     
    REFERENCES dbo.Genres (Id)     
    ON DELETE CASCADE    
    ON UPDATE CASCADE    
;    
GO 