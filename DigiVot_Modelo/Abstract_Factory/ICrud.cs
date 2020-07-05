using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiVot_Modelo
{
    public interface ICrud
    {
        bool Insertar(Object  VO);
        bool Modificar(Object VO);
        bool Eliminar(Object VO);
        List<Object> Listar(Object VO);
    }
}
