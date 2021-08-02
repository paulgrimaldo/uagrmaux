<?php

class AlumnosGruposTareasController
{

    public function index()
    {
        $alumnosGrupos = AlumnoGrupo::all();
        $tareas = Tarea::all();
        $alumnosGruposTareas = AlumnoGrupoTarea::all();
        $mensaje = '';
        require_once('../app/views/alumnosGruposTareas/index.php');
    }

    public function guardar()
    {
        $alumnosGruposTareas = AlumnoGrupoTarea::all();
        if (isset($_POST['alumnosGruposId']) && isset($_POST['tareasId']) && isset($_POST['calificaciones']) && isset($_POST['partesTareas'])) {
            $alumnosGruposId = $_POST['alumnosGruposId'];
            $tareasId = $_POST['tareasId'];
            $calificaciones = $_POST['calificaciones'];
            $partesTareas = $_POST['partesTareas'];
            for ($i = 0; $i < sizeof($alumnosGruposId); $i++) {
                $alumnoGrupoId = $alumnosGruposId[$i];
                $tareaId = $tareasId[$i];
                $calificacion = $calificaciones[$i];
                $parteTarea = $partesTareas[$i];

                $save = $this->guardarAlumnoGrupoTarea($alumnoGrupoId, $tareaId, $calificacion, $parteTarea);
                if (!$save) {
                    $mensaje = 'No se pudo guardar';
                }
            }
            $mensaje = 'Guardo exitoso';
            $alumnosGruposTareas = AlumnoGrupoTarea::all();
        } else {
            $mensaje = 'Deben ingresarse todos los datos';
        }
        $alumnosGrupos = AlumnoGrupo::all();
        $tareas = Tarea::all();
        require_once('../app/views/alumnosGruposTareas/index.php');
    }

    private function guardarAlumnoGrupoTarea($alumnoGrupoId, $tareaId, $calificacion, $parteTarea)
    {
        if (count(AlumnoGrupoTarea::exists($alumnoGrupoId, $tareaId)) == 0) {
            $model = new AlumnoGrupoTarea(null, $alumnoGrupoId, $tareaId, $calificacion, $parteTarea);
            return $model->guardar();
        } else {
            return false;
        }
    }
}