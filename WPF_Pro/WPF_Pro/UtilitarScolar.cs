using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Pro
{
    class UtilitarScolar
    {


        public int Calcul_Credite(int id)
        {
            int Nr_credite = 0;
            using (var ctx = new FacultateaXEntities1())
            {

                var catalogu = ctx.Catalog_note.SqlQuery("select * from Catalog_note where Id_cont='" + id + "'").ToList();
                for (int i = 0; i < catalogu.Count(); i++)
                {
                    if (catalogu[i].Nota_Examen.Value >= 5)
                    {
                        Nr_credite = Nr_credite + catalogu[i].Nr_credite.Value;
                    }
                    else if (catalogu[i].Nota_restanta.Value >= 5)
                    {
                        Nr_credite = Nr_credite + catalogu[i].Nr_credite.Value;
                    }
                }

            }
            return Nr_credite; ;
        }
        public int calcul_restante(int id)
        {
            int Nr_restante = 0;
            using (var ctx = new FacultateaXEntities1())
            {
                int ok = 1;

                var catalogu = ctx.Catalog_note.SqlQuery("select * from Catalog_note where Id_cont='" + id + "'").ToList();
                for (int i = 0; i < catalogu.Count(); i++)
                {
                    if (catalogu[i].Nota_Examen.Value < 5 && catalogu[i].Data_restanta == null &&catalogu[i].Nota_restanta==0)
                    {
                        Nr_restante++;
                        ok = 0;
                    }
                    else if (catalogu[i].Nota_restanta != 0)
                    {
                        if (catalogu[i].Nota_restanta.Value < 5 && ok == 1)
                            Nr_restante++;
                    }
                    ok = 1;
                }
                int noOfRowUpdated = ctx.Database.ExecuteSqlCommand("update Studenti set Numar_restante='" + Nr_restante + "'where Id_cont='" + id + "'");
            }
            return Nr_restante;
        }
        public float calcul_medie(int id)
        {

            using (var ctx = new FacultateaXEntities1())
            {

                float medie = 0;

                int nr_materii = ctx.Database.SqlQuery<int>("select count(*) from Catalog_note where Id_cont='" + id + "'").FirstOrDefault();
                var catalogu = ctx.Catalog_note.SqlQuery("select * from Catalog_note where Id_cont='" + id + "'").ToList();
                for (int i = 0; i < catalogu.Count(); i++)
                {
                    if (catalogu[i].Data_restanta == null && catalogu[i].Nota_Examen != null)
                    {
                        medie = medie + catalogu[i].Nota_Examen.Value;

                    }
                    else if (catalogu[i].Nota_restanta != null)
                    {
                        medie = medie + catalogu[i].Nota_restanta.Value;
                    }
                    else
                    {
                        medie = medie + catalogu[i].Nota_Examen.Value;
                    }


                }
                medie = medie / nr_materii;
                return medie;
            }
        }
        public float calcul_med_grup(List<CStud> list)
        {
            float medie = 0;
            for (int i = 0; i < list.Count(); i++)
            {
                if (list[i].Data_restanta == null && list[i].Nota_Examen == 0)
                {
                    medie = medie + System.Convert.ToInt32(list[i].Nota_Examen);

                }
                else if (list[i].Nota_restanta != 0)
                {
                    medie = medie + System.Convert.ToInt32(list[i].Nota_restanta);
                }
                else
                {
                    medie = medie + System.Convert.ToInt32(list[i].Nota_Examen);
                }


            }
            medie = medie / list.Count();
            return medie;
        }
        public int nr_restantieri(List<CStud> list)
        {
            int nr_r = 0;
            int ok = 1;
            for (int i = 0; i < list.Count(); i++)
            {
                if (System.Convert.ToInt32(list[i].Nota_Examen) < 5 && list[i].Data_restanta == null)
                {
                    nr_r++;
                    ok = 0;
                }
                else if (list[i].Nota_restanta != 0)
                {
                    if (System.Convert.ToInt32(list[i].Nota_restanta) < 5 && ok == 1)
                        nr_r++;
                }
                ok = 1;
            }
            return nr_r;
        }
    }



}
