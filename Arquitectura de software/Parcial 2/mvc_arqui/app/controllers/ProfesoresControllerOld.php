<?php

class ProfesoresControllerOld
{

    public function index()
    {
        $profesores = Profesor::all();
        $mensaje = '';
        require_once('../app/views/profesores/index.php');
    }

    public function guardar()
    {
        $profesores = Profesor::all();
        if (isset($_POST['nombre']) && isset($_POST['codigo'])) {
            $nombre = $_POST['nombre'];
            $codigo = $_POST['codigo'];

            if (count(Profesor::exists($codigo)) == 0) {
                $save = Profesor::guardar($nombre, $codigo);
                if ($save) {
                    $profesores = Profesor::all();
                    $mensaje = 'Guardado correctamente';
                } else {
                    $mensaje = 'Error al guardar profesor';
                }
            } else {
                $mensaje = 'El profesor ya existe';
            }
        } else {
            $mensaje = 'Deben ingresarse todos los datos';
        }
        require_once('../app/views/profesores/index.php');
    }
}