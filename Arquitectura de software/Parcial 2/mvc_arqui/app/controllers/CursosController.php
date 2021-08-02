<?php

class CursosController
{

    public function index()
    {
        $cursos = Curso::all();
        $mensaje = '';
        require_once('../app/views/cursos/index.php');
    }

    public function guardar()
    {
        $cursos = Curso::all();
        if (isset($_POST['nombre']) && isset($_POST['nivel'])) {
            $nombre = $_POST['nombre'];
            $nivel = $_POST['nivel'];

            $model = new Curso(null, $nombre, $nivel);
            $save = $model->guardar();
            if ($save) {
                $cursos = Curso::all();
                $mensaje = 'Guardado correctamente';
            } else {
                $mensaje = 'Error al guardar curso';
            }
        } else {
            $mensaje = 'Deben ingresarse todos los datos';
        }
        require_once('../app/views/cursos/index.php');
    }
}