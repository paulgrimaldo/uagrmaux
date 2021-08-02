<?php
/**
 * Created by PhpStorm.
 * Date: 15/4/2017
 * Time: 2:16 AM
 */

/*
 * referencia al archivo PHP que conecta a la Base de Datos
 */
require_once('../app/database/connection.php');

//region load singletons
include '../app/services/CursosMateriasSubjectsSingleton.php';
include '../app/services/TareaObserver.php';
include '../app/services/TareaObservable.php';
include '../app/services/GrupoTareaObserver.php';
include '../app/services/GrupoTareaSubject.php';
include '../app/models/AbstractModel.php';
include '../app/models/CursoMateria.php';
include '../app/models/Grupo.php';
include '../app/models/Tarea.php';
//endregion
session_start();
/*
 * validamos si entra como parametro las variables ['controller'] y ['action']
 */
if (isset($_GET['controller']) && isset($_GET['action'])) {
    $controller = $_GET['controller'];
    $action = $_GET['action'];
} else {
    /*
     * caso contrario que no ingrese ningun parametro o este mal escrito entonces
     * se redireccionara automaticamente a 'pages' y 'home'
     */
    $controller = 'Pages';
    $action = 'home';
}

/*
 * echo '<pre>'; print_r($list); echo '</pre>';
 * cargamos el archivo (layout.php) que contendra la plantilla del proyecto
 * es decir la cabezera de la pagina, el menu y el pie de pagina.
 */
require_once('../app/routes.php');