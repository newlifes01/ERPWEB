﻿using Core.Erp.Info.General;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Data.General
{
   public class Visor_video_Data
    {
        public List<Visor_video_Info> get_list(bool mostrar_anulados)
        {
            try
            {
                List<Visor_video_Info> Lista;
                using (Entities_general Context = new Entities_general())
                {
                        Lista = (from q in Context.tb_visor_video
                                 select new Visor_video_Info
                                 {
                                     Cod_video = q.Cod_video,
                                     Nombre_video = q.Nombre_video
                                 }).ToList();
                    
                }
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

      
        public bool guardarDB(Visor_video_Info info)
        {
            try
            {
                using (Entities_general Context = new Entities_general())
                {
                    tb_visor_video Entity = new tb_visor_video
                    {
                        Cod_video = info.Cod_video,
                        Nombre_video = info.Nombre_video,
                        IdUsuario = info.IdUsuario
                    };
                    Context.tb_visor_video.Add(Entity);
                    Context.SaveChanges();

                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

    
        public bool modificarDB(Visor_video_Info info)
        {
            try
            {
                using (Entities_general Context = new Entities_general())
                {
                    tb_visor_video Entity = Context.tb_visor_video.FirstOrDefault(q => q.Cod_video == info.Cod_video);
                    if (Entity == null)
                        return false;
                    Entity.Nombre_video = info.Nombre_video;
                    Entity.IdUsuarioModifica = info.IdUsuarioModifica;
                    Context.SaveChanges();

                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool anularDB(Visor_video_Info info)
        {
            try
            {
                using (Entities_general Context = new Entities_general())
                {
                    tb_visor_video Entity = Context.tb_visor_video.FirstOrDefault(q => q.Cod_video == info.Cod_video);
                    if (Entity == null)
                        return false;
                    Entity.Estado = false;
                    Entity.IdUsuarioAnulacion = info.IdUsuarioAnulacion;
                    Context.SaveChanges();

                }
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
