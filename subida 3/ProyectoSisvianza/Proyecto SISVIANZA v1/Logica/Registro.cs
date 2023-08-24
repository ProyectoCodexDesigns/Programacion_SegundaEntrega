using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Proyecto_SISVIANZA_v1.Persistencia;

namespace Proyecto_SISVIANZA_v1.Logica
{

    class Registro
    {
        private RegistroPersistencia registroPersistencia;
        public Registro() => registroPersistencia = new RegistroPersistencia();
        public void Registrar(string ci, string password, string rol) => registroPersistencia.Registrar(ci, password, rol);
        public void Actualizar(string ci, string password, string rol) => registroPersistencia.Actualizar(ci, password, rol);
        public void Eliminar(string ci) => registroPersistencia.Eliminar(ci);
        public Boolean VerificarRol(string rol) => registroPersistencia.VerificarRol(rol);
        public Boolean Cidiff(string ci) => registroPersistencia.Cidiff(ci);
    }
}
