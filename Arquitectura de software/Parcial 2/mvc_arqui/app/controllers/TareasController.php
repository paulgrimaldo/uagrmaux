<?php

class TareasController
{

    public function index()
    {
        $tareas = Tarea::all();
        $cursosMaterias = CursoMateria::all();
        $mensaje = '';
        require_once('../app/views/tareas/index.php');
    }

    public function guardar()
    {
        $tareas = Tarea::all();
        if (isset($_POST['nombre']) && isset($_POST['valorNota']) && isset($_POST['cursoMateriaId'])) {
            $nombre = $_POST['nombre'];
            $valorNota = $_POST['valorNota'];
            $cursoMateriaId = $_POST['cursoMateriaId'];

            $model = new Tarea(null, $nombre, $valorNota, $cursoMateriaId);
            $save = $model->guardar();
            if ($save) {
                //Notificar a los grupos del cursoMateria
                $cms = $_SESSION['cms'];
                $cursoMateriaSubject = $cms->getCursoMateriaSubject((int)$cursoMateriaId);
                if ($cursoMateriaSubject != null) {
                    $cursoMateriaSubject->notificar($model);
                }

                $tareas = Tarea::all();
                $mensaje = 'Guardado correctamente';
            } else {
                $mensaje = 'Error al guardar';
            }
        } else {
            $mensaje = 'Deben ingresarse todos los datos';
        }
        $cursosMaterias = CursoMateria::all();
        require_once('../app/views/tareas/index.php');
    }
}