<?php

class GruposController
{

    public function index()
    {
        $grupos = Grupo::all();
        $cursosMaterias = CursoMateria::all();
        $mensaje = '';
        require_once('../app/views/grupos/index.php');
    }

    public function guardar()
    {
        $grupos = Grupo::all();
        if (isset($_POST['nombre']) && isset($_POST['cursoMateriaId'])) {
            $nombre = $_POST['nombre'];
            $cursoMateriaId = $_POST['cursoMateriaId'];

            $model = new Grupo(null, $nombre, $cursoMateriaId);
            $save = $model->guardar();
            if ($save) {
                //Agregar el grupo como observador
                $observer = new GrupoTareaObserver($model);
                $cms = $_SESSION['cms'];
                $cursoMateriaSubject = $cms->getCursoMateriaSubject((int)$cursoMateriaId);
                if ($cursoMateriaSubject != null)
                    $cursoMateriaSubject->addObserver($observer);

                $grupos = Grupo::all();
                $mensaje = 'Guardado correctamente';
            } else {
                $mensaje = 'Error al guardar';
            }
        } else {
            $mensaje = 'Deben ingresarse todos los datos';
        }
        $cursosMaterias = CursoMateria::all();
        require_once('../app/views/grupos/index.php');
    }
}