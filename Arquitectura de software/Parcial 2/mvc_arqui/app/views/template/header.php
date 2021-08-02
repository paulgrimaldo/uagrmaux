<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width,initial-scale=1">
    <meta name="description" content="A fully featured admin theme which can be used to build CRM, CMS, etc.">
    <meta name="author" content="Coderthemes">

    <link rel="shortcut icon" href="assets/images/favicon.ico">

    <title>Administrador tareas colegios</title>

    <link href="../plugins/switchery/switchery.min.css" rel="stylesheet"/>

    <link href="assets/css/bootstrap.min.css" rel="stylesheet" type="text/css">
    <link href="assets/css/icons.css" rel="stylesheet" type="text/css">
    <link href="assets/css/style.css" rel="stylesheet" type="text/css">

    <script src="assets/js/modernizr.min.js"></script>

</head>


<body class="fixed-left">


<!-- Begin page -->
<div id="wrapper">

    <!-- Top Bar Start -->
    <div class="topbar">

        <!-- LOGO -->
        <div class="topbar-left">
            <div class="text-center">
                <a href="?" class="logo"><i class="mdi mdi-radar"></i> <span>Admin</span></a>
            </div>
        </div>

        <!-- Button mobile view to collapse sidebar menu -->
        <nav class="navbar-custom">

            <ul class="list-inline float-right mb-0">

                <li class="list-inline-item notification-list hide-phone">
                    <a class="nav-link waves-light waves-effect" href="#" id="btn-fullscreen">
                        <i class="mdi mdi-crop-free noti-icon"></i>
                    </a>
                </li>

                <li class="list-inline-item notification-list">
                    <a class="nav-link right-bar-toggle waves-light waves-effect" href="#">
                        <i class="mdi mdi-dots-horizontal noti-icon"></i>
                    </a>
                </li>

                <li class="list-inline-item dropdown notification-list">
                    <a class="nav-link dropdown-toggle arrow-none waves-light waves-effect" data-toggle="dropdown"
                       href="#" role="button"
                       aria-haspopup="false" aria-expanded="false">
                        <i class="mdi mdi-bell noti-icon"></i>
                        <span class="badge badge-pink noti-icon-badge">4</span>
                    </a>
                    <div class="dropdown-menu dropdown-menu-right dropdown-arrow dropdown-menu-lg"
                         aria-labelledby="Preview">
                        <!-- item-->
                        <div class="dropdown-item noti-title">
                            <h5 class="font-16"><span class="badge badge-danger float-right">5</span>Notification</h5>
                        </div>

                        <!-- item-->
                        <a href="javascript:void(0);" class="dropdown-item notify-item">
                            <div class="notify-icon bg-success"><i class="mdi mdi-comment-account"></i></div>
                            <p class="notify-details">Robert S. Taylor commented on Admin
                                <small class="text-muted">1 min ago</small>
                            </p>
                        </a>

                        <!-- item-->
                        <a href="javascript:void(0);" class="dropdown-item notify-item">
                            <div class="notify-icon bg-info"><i class="mdi mdi-account"></i></div>
                            <p class="notify-details">New user registered.
                                <small class="text-muted">1 min ago</small>
                            </p>
                        </a>

                        <!-- item-->
                        <a href="javascript:void(0);" class="dropdown-item notify-item">
                            <div class="notify-icon bg-danger"><i class="mdi mdi-airplane"></i></div>
                            <p class="notify-details">Carlos Crouch liked <b>Admin</b>
                                <small class="text-muted">1 min ago</small>
                            </p>
                        </a>

                        <!-- All-->
                        <a href="javascript:void(0);" class="dropdown-item notify-item notify-all">
                            View All
                        </a>

                    </div>
                </li>

                <li class="list-inline-item dropdown notification-list">
                    <a class="nav-link dropdown-toggle waves-effect waves-light nav-user" data-toggle="dropdown"
                       href="#" role="button"
                       aria-haspopup="false" aria-expanded="false">
                        <img src="assets/images/users/avatar-1.jpg" alt="user" class="rounded-circle">
                    </a>
                    <div class="dropdown-menu dropdown-menu-right profile-dropdown " aria-labelledby="Preview">
                        <!-- item-->
                        <div class="dropdown-item noti-title">
                            <h5 class="text-overflow">
                                <small>Hola</small>
                            </h5>
                        </div>

                        <!-- item-->
                        <a href="javascript:void(0);" class="dropdown-item notify-item">
                            <i class="mdi mdi-account"></i> <span>Profile</span>
                        </a>

                        <!-- item-->
                        <a href="javascript:void(0);" class="dropdown-item notify-item">
                            <i class="mdi mdi-settings"></i> <span>Settings</span>
                        </a>

                        <!-- item-->
                        <a href="javascript:void(0);" class="dropdown-item notify-item">
                            <i class="mdi mdi-lock-open"></i> <span>Lock Screen</span>
                        </a>

                        <!-- item-->
                        <a href="#" class="dropdown-item notify-item">
                            <i class="mdi mdi-logout"></i> <span>Logout</span>
                        </a>

                    </div>
                </li>

            </ul>

            <ul class="list-inline menu-left mb-0">
                <li class="float-left">
                    <button class="button-menu-mobile open-left waves-light waves-effect">
                        <i class="mdi mdi-menu"></i>
                    </button>
                </li>
                <li class="hide-phone app-search">
                    <form role="search" class="">
                        <input type="text" placeholder="Search..." class="form-control">
                        <a href="#"><i class="fa fa-search"></i></a>
                    </form>
                </li>
            </ul>

        </nav>

    </div>
    <!-- Top Bar End -->


    <!-- ========== Left Sidebar Start ========== -->

    <div class="left side-menu">
        <div class="sidebar-inner slimscrollleft">
            <!--- Divider -->
            <div id="sidebar-menu">
                <ul>
                    <li class="menu-title">Menu</li>

                    <li>
                        <a href="?controller=Pages&action=home" class="waves-effect waves-primary">
                            <i class="ti-home"></i><span> Pag. Principal </span></a>
                    </li>
                    <li class="has_sub">
                        <a href="javascript:void(0);" class="waves-effect waves-primary"><i class="ti-paint-bucket"></i>
                            <span>Administrativo</span>
                            <span class="menu-arrow"></span></a>
                        <ul class="list-unstyled">
                            <li><a href="?controller=Alumnos&action=index">Alumnos</a></li>
                            <li><a href="?controller=Materias&action=index">Materias</a></li>
                            <li><a href="?controller=Cursos&action=index">Cursos</a></li>
                            <li><a href="?controller=Profesores&action=index">Profesores</a></li>
                            <li><a href="?controller=CursosMaterias&action=index">Asignar curso, materia, profesor</a>
                            </li>
                            <li><a href="?controller=Grupos&action=index">Grupos</a></li>
                            <li><a href="?controller=AlumnosGrupos&action=index">Asignar alumnos, grupos</a></li>
                            <li><a href="?controller=Tareas&action=index">Tareas</a></li>
                            <li><a href="?controller=AlumnosGruposTareas&action=index">Presentaciones</a></li>
                            <!--  <li><a href="?controller=marcas&action=index">Marca Vehiculo</a></li>
                              <li><a href="?controller=modelos&action=index">Modelo Vehiculo</a></li>
                              <li><a href="?controller=tiposvehiculos&action=index">Tipo de Vehiculo</a></li>
                              <li><a href="?controller=vehiculos&action=index">Registrar Vehiculo</a></li>
                              <li><a href="?controller=servicios&action=index">Servicio</a></li>
                              <li><a href="?controller=ordenes&action=index">Registrar Ordenes</a></li>-->
                        </ul>
                    </li>

                </ul>
                <div class="clearfix"></div>
            </div>
            <div class="clearfix"></div>
        </div>
    </div>
    <!-- Left Sidebar End -->


    <!-- ============================================================== -->
    <!-- Start right Content here -->
    <!-- ============================================================== -->
    <div class="content-page">
        <!-- Start content -->
        <div class="content">
            <div class="container-fluid">
                <p style="color: #ff2424"> <?php
                    if (isset($_SESSION['notificacion']) && $_SESSION['notificacion'] != null) {
                        echo $_SESSION['notificacion'];
                        unset($_SESSION['notificacion']);
                    }
                    ?></p>
