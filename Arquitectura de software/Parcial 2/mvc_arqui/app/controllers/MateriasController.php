<?php

class MateriasController
{

    public function index()
    {
        $materias = Materia::all();
        $mensaje = '';
        require_once('../app/views/materias/index.php');
    }

    public function guardar()
    {
        $materias = Materia::all();
        if (isset($_POST['nombre']) && isset($_POST['sigla'])) {
            $nombre = $_POST['nombre'];
            $sigla = $_POST['sigla'];

            $model = new Materia(null, $sigla, $nombre);
            $save = $model->guardar();
            if ($save) {
                $materias = Materia::all();
                $mensaje = 'Guardado correctamente';
            } else {
                $mensaje = 'Error al guardar materia';
            }
        } else {
            $mensaje = 'Deben ingresarse todos los datos';
        }
        require_once('../app/views/materias/index.php');
    }
}