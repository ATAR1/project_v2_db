-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GET_CURENT_STOR]
@id_storage int
AS
BEGIN
SELECT    material.id_mat as MAT_ID, material.name AS MAT_name, storage.name, storage.city, storage.street, storage_nal.count , ED_IZM.name_ed
FROM            storage INNER JOIN
                         storage_nal ON storage.id_storage = storage_nal.id_storage inner JOIN
						 material ON storage_nal.id_mat = material.id_mat
						 inner join [dbo].[ED_IZM] on material.id_ed = [dbo].[ED_IZM].[id_ed]
						 WHERE storage.id_storage = @id_storage
END