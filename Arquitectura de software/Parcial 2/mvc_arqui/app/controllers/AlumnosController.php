<?php

class AlumnosController
{

    public function index()
    {
        $alumnos = Alumno::all();
        $mensaje = '';
        require_once('../app/views/alumnos/index.php');
    }


    public function guardar()
    {
        $alumnos = Alumno::all();
        if (isset($_POST['nombre']) && isset($_POST['ci']) && isset($_POST['email'])) {
            $nombre = $_POST['nombre'];
            $ci = $_POST['ci'];
            $email = $_POST['email'];

            if (count(Alumno::exists($ci)) == 0) {
                $model = new Alumno(null, $nombre, $ci, $email);
                $save = $model->guardar();
                if ($save) {
                    $alumnos = Alumno::all();
                    $mensaje = 'Guardado correctamente';
                } else {
                    $mensaje = 'Error al guardar alumno';
                }
            } else {
                $mensaje = 'El alumno ya existe';
            }
        } else {
            $mensaje = 'Deben ingresarse todos los datos';
        }
        require_once('../app/views/alumnos/index.php');
    }
}