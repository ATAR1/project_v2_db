-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GET_REP_MAT]
@id_jobs int
AS
BEGIN

SELECT        planjob.id,jobs.name, jobs.count AS plane_count, planjob.fakt_count, planjob.date, employess.staff,employess.fio as EMP_FIO, employess.fio, employess.telefone, material.name AS Material, ED_IZM.name_ed,planjob.fact_date
FROM            planjob INNER JOIN
                         jobs ON planjob.id_jobs = jobs.id_jobs INNER JOIN
                         employess ON planjob.id_emp = employess.id_emp INNER JOIN
                         material ON planjob.id_mat = material.id_mat INNER JOIN
                         ED_IZM ON material.id_ed = ED_IZM.id_ed
						 WHERE planjob.id = @id_jobs

END