$(function() { 
    $('#sidebarCollapse').on('click', function() {
      $('#sidebar, #content').toggleClass('active');
    });
});

$(document).ready(function () {
    var dataTable = $('#Newtable').DataTable({
        "pageLength": 5,
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort'],
        }],
        columnDefs: [
            { type: 'date-dd-mm-yyyy', aTargets: [5] }
        ],
        "aoColumns": [
            null,
            null,
            null,
            null,
            null,
            null

        ],
        "order": false,
        "bLengthChange": false,
        "dom": '<"top">ct<"top"p><"clear">'
    });
    $("#filterbox").keyup(function () {
        dataTable.search(this.value).draw();
    });
});

$(document).ready(function () {
    var dataTable = $('#newtable').DataTable({
        "pageLength": 5,
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort'],
        }],
        columnDefs: [
            { type: 'date-dd-mm-yyyy', aTargets: [5] }
        ],
        "aoColumns": [
            null,
            null,
            null,
            null,
            null,
            null

        ],
        "order": false,
        "bLengthChange": false,
        "dom": '<"top">ct<"top"p><"clear">'
    });
    $("#filterbox").keyup(function () {
        dataTable.search(this.value).draw();
    });
});

$(document).ready(function () {
    var dataTable = $('#Opentable').DataTable({
        "pageLength": 5,
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort'],
        }],
        columnDefs: [
            { type: 'date-dd-mm-yyyy', aTargets: [5] }
        ],
        "aoColumns": [
            null,
            null,
            null,
            null,
            null,
            null

        ],
        "order": false,
        "bLengthChange": false,
        "dom": '<"top">ct<"top"p><"clear">'
    });
    $("#filterbox").keyup(function () {
        dataTable.search(this.value).draw();
    });
});

$(document).ready(function () {
    var dataTable = $('#Closedtable').DataTable({
        "pageLength": 5,
        'aoColumnDefs': [{
            'bSortable': false,
            'aTargets': ['nosort'],
        }],
        columnDefs: [
            { type: 'date-dd-mm-yyyy', aTargets: [5] }
        ],
        "aoColumns": [
            null,
            null,
            null,
            null,
            null,
            null

        ],
        "order": false,
        "bLengthChange": false,
        "dom": '<"top">ct<"top"p><"clear">'
    });
    $("#filterbox").keyup(function () {
        dataTable.search(this.value).draw();
    });
});

