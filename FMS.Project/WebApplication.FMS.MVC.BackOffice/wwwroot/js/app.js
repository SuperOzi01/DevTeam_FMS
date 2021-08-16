// Side Bar " Toggle "
$(function () {
    $('#sidebarCollapse').on('click', function() {
      $('#sidebar, #content').toggleClass('active');
    });
});


// Datatable
$(document).ready(function () {


    // Maintanance Manager Dashboard New Table "Datatable"
    var MaintananceManagerDashboardNewtable = $('#MaintananceManagerDashboardNewtable').DataTable({
        "pageLength": 5,
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort'],
        }],
        "aoColumns": [
            null,
            null,
            null,
            null,
            null
        ],

        "bLengthChange": false,
        "dom": '<"top">ct<"top"p><"clear">'
    });
    $("#MaintananceManagerDashboardfilterbox").keyup(function () {
        MaintananceManagerDashboardNewtable.search(this.value).draw();
    });


    // Maintanance Manager New  table "Datatable"
    var MaintananceManagerNew2table = $('#MaintananceManagerNew2table').DataTable({
        "pageLength": 5,
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort'],
        }],
        "aoColumns": [
            null,
            null,
            null,
            null,
            null
        ],

        "bLengthChange": false,
        "dom": '<"top">ct<"top"p><"clear">'
    });
    $("#MaintananceManagerNew2tablefilterbox").keyup(function () {
        MaintananceManagerNew2table.search(this.value).draw();
    });

    // Maintanance Manager Open Table "Datatable"
    var MaintananceManagerOpentable = $('#MaintananceManagerOpentable').DataTable({
        "pageLength": 5,
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort'],
        }],
        "aoColumns": [
            null,
            null,
            null,
            null,
            null
        ],

        "bLengthChange": false,
        "dom": '<"top">ct<"top"p><"clear">'
    });
    $("#MaintananceManagerOpentablefilterboxfilterbox").keyup(function () {
        MaintananceManagerOpentable.search(this.value).draw();
    });

    //  Maintanance Manager Closed Table "Datatable"
    var MaintananceManagerClosedtable = $('#MaintananceManagerClosedtable').DataTable({
        "pageLength": 5,
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort'],
        }],
        "aoColumns": [
            null,
            null,
            null,
            null,
            null,
            null
        ],

        "bLengthChange": false,
        "dom": '<"top">ct<"top"p><"clear">'
    });
    $("#MaintananceManagerClosedtablefilterbox").keyup(function () {
        MaintananceManagerClosedtable.search(this.value).draw();
    });

    //  Maintanance Manager Canceled Table "Datatable"
    var MaintananceManagerCanceledtable = $('#MaintananceManagerCanceledtable').DataTable({
        "pageLength": 5,
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort'],
        }],
        "aoColumns": [
            null,
            null,
            null,
            null,
            null,
            null
        ],

        "bLengthChange": false,
        "dom": '<"top">ct<"top"p><"clear">'
    });
    $("#MaintananceManagerCanceledtablefilterbox").keyup(function () {
        MaintananceManagerCanceledtable.search(this.value).draw();
    });

    // Building Manager Dashboard New table "Datatable"
    var BuildingManagerDashboardNewtable = $('#BuildingManagerDashboardNewtable').DataTable({
        "pageLength": 5,
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort'],
        }],
        "aoColumns": [
            null,
            null,
            null
        ],

        "bLengthChange": false,
        "dom": '<"top">ct<"top"p><"clear">'
    });
    $("#BuildingManagerDashboardNewtablefilterbox").keyup(function () {
        BuildingManagerDashboardNewtable.search(this.value).draw();
    });


    // Building Manager Maintanance Requests New table
    var BuildingManagerMaintananceRequestsNewtable = $('#BuildingManagerMaintananceRequestsNewtable').DataTable({
        "pageLength": 5,
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort'],
        }],
        "aoColumns": [
            null,
            null,
            null,
            null
          
        ],

        "bLengthChange": false,
        "dom": '<"top">ct<"top"p><"clear">'
    });
    $("#BuildingManagerMaintananceRequestsNewtablefilterbox").keyup(function () {
        BuildingManagerMaintananceRequestsNewtable.search(this.value).draw();
    });


    // Building Manager Maintanance Requests Open table
    var BuildingManagerMaintananceRequestsOpentable = $('#BuildingManagerMaintananceRequestsOpentable').DataTable({
        "pageLength": 5,
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort'],
        }],
        "aoColumns": [
            null,
            null,
            null
        ],

        "bLengthChange": false,
        "dom": '<"top">ct<"top"p><"clear">'
    });
    $("#BuildingManagerMaintananceRequestsOpentablefilterbox").keyup(function () {
        BuildingManagerMaintananceRequestsOpentable.search(this.value).draw();
    });



    // Building Manager Maintanance Requests Closed table
    var BuildingManagerMaintananceRequestsClosedtable = $('#BuildingManagerMaintananceRequestsClosedtable').DataTable({
        "pageLength": 5,
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort'],
        }],
        "aoColumns": [
            null,
            null,
            null,
            null,
            null
        ],

        "bLengthChange": false,
        "dom": '<"top">ct<"top"p><"clear">'
    });
    $("#BuildingManagerMaintananceRequestsClosedtablefilterbox").keyup(function () {
        BuildingManagerMaintananceRequestsClosedtable.search(this.value).draw();
    });


    // Building Manager Maintanance Requests Canceled table
    var BuildingManagerMaintananceRequestsCanceledtable = $('#BuildingManagerMaintananceRequestsCanceledtable').DataTable({
        "pageLength": 5,
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort'],
        }],
        "aoColumns": [
            null,
            null,
            null,
            null
        ],

        "bLengthChange": false,
        "dom": '<"top">ct<"top"p><"clear">'
    });
    $("#BuildingManagerMaintananceRequestsCanceledtablefilterbox").keyup(function () {
        BuildingManagerMaintananceRequestsCanceledtable.search(this.value).draw();
    });

    // Maintanance Worker Dashboard New table
    var MaintananceWorkerDashboardNewtable = $('#MaintananceWorkerDashboardNewtable').DataTable({
        "pageLength": 5,
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort'],
        }],
        "aoColumns": [
            null,
            null,
            null,
            null,
            null
        ],

        "bLengthChange": false,
        "dom": '<"top">ct<"top"p><"clear">'
    });
    $("#MaintananceWorkerDashboardNewtablefilterbox").keyup(function () {
        MaintananceWorkerDashboardNewtable.search(this.value).draw();
    });

    // Maintanance Worker Requests New table
    var MaintananceWorkerRequestsNewtable = $('#MaintananceWorkerRequestsNewtable').DataTable({
        "pageLength": 5,
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort'],
        }],
        "aoColumns": [
            null,
            null,
            null,
            null
        ],

        "bLengthChange": false,
        "dom": '<"top">ct<"top"p><"clear">'
    });
    $("#MaintananceWorkerRequestsNewtablefilterbox").keyup(function () {
        MaintananceWorkerRequestsNewtable.search(this.value).draw();
    });

    // Maintanance Worker Requests Closed table
    var MaintananceWorkerRequestsClosedtable = $('#MaintananceWorkerRequestsClosedtable').DataTable({
        "pageLength": 5,
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort'],
        }],
        "aoColumns": [
            null,
            null,
            null,
            null
        ],

        "bLengthChange": false,
        "dom": '<"top">ct<"top"p><"clear">'
    });
    $("#MaintananceWorkerRequestsClosedtablefilterbox").keyup(function () {
        MaintananceWorkerRequestsClosedtable.search(this.value).draw();
    });

});