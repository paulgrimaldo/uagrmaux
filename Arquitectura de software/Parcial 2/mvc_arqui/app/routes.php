<?php


function call($controller, $action)
{
    $file_controller = 'controllers/' . $controller . 'Controller.php';
    require_once($file_controller); ///aqui se hace existencia de las CLASS

    require_once('models/AbstractModel.php');


    switch ($controller) {
        case 'Pages': //`principal`
            $controller = new PagesController();
            break;
        case 'Alumnos':
            require_once('models/Alumno.php');
            $controller = new AlumnosController();
            break;
        case 'Materias':
            require_once('models/Materia.php');
            $controller = new MateriasController();
            break;
        case 'Cursos':
            require_once('models/Curso.php');
            $controller = new CursosController();
            break;
        case 'Profesores':
            require_once('models/Profesor.php');
            $controller = new ProfesoresController();
            break;
        case 'CursosMaterias':
            require_once('models/Profesor.php');
            require_once('models/Curso.php');
            require_once('models/Materia.php');
            require_once('models/CursoMateria.php');
            require_once ('services/TareaObservable.php');
            require_once ('services/TareaObserver.php');
            require_once ('services/GrupoTareaObserver.php');
            require_once ('services/GrupoTareaSubject.php');
            require_once ('services/CursosMateriasSubjectsSingleton.php');

            $controller = new CursosMateriasController();
            break;
        case 'Grupos':
            require_once('models/Grupo.php');
            require_once('models/CursoMateria.php');
            require_once ('services/TareaObservable.php');
            require_once ('services/TareaObserver.php');
            require_once ('services/GrupoTareaObserver.php');
            require_once ('services/GrupoTareaSubject.php');
            require_once ('services/CursosMateriasSubjectsSingleton.php');

            $controller = new GruposController();
            break;
        case 'AlumnosGrupos':
            require_once('models/Grupo.php');
            require_once('models/Alumno.php');
            require_once('models/AlumnoGrupo.php');
            $controller = new AlumnosGruposController();
            break;
        case 'Tareas':
            require_once('models/Tarea.php');
            require_once('models/CursoMateria.php');
            require_once ('services/TareaObservable.php');
            require_once ('services/TareaObserver.php');
            require_once ('services/GrupoTareaObserver.php');
            require_once ('services/GrupoTareaSubject.php');
            require_once ('services/CursosMateriasSubjectsSingleton.php');

            $controller = new TareasController();
            break;
        case 'AlumnosGruposTareas':
            require_once('models/Tarea.php');
            require_once('models/AlumnoGrupo.php');
            require_once('models/AlumnoGrupoTarea.php');
            $controller = new AlumnosGruposTareasController();
            break;
    }
    $controller->{$action}();
}

// agregar la entrada para el nuevo controlador y sus acciones
$controllers = array(
    'Pages' => ['home', 'error'],
    'Alumnos' => ['index', 'guardar'],
    'Materias' => ['index', 'guardar'],
    'Cursos' => ['index', 'guardar'],
    'Profesores' => ['index', 'guardar'],
    'CursosMaterias' => ['index', 'guardar'],
    'Grupos' => ['index', 'guardar'],
    'AlumnosGrupos' => ['index', 'guardar'],
    'Tareas' => ['index', 'guardar'],
    'AlumnosGruposTareas' => ['index', 'guardar'],
    /* 'clientes' => ['index', 'guardar', 'redi', 'eliminar', 'editar2'],
     'marcas' => ['index', 'guardar', 'eliminar', 'editar'],
     'tiposvehiculos' => ['index', 'guardar', 'eliminar', 'editar'],
     'vehiculos' => ['index', 'guardar', 'eliminar', 'editar'],
     'modelos' => ['index', 'guardar', 'eliminar', 'editar'],
     'servicios' => ['index', 'guardar', 'eliminar', 'editar'],
     'ordenes' => ['index', 'guardar', 'eliminar', 'editar', 'buscar'],*/

);

if (array_key_exists($controller, $controllers)) {
    if (in_array($action, $controllers[$controller])) {
        call($controller, $action);
    } else {
        call('Pages', 'error500');
    }
} else {
    call('Pages', 'error404');
}
