$(document).ready(function () {
    AutoInitAllDataTables();
});

$(document).on("ajaxSuccess", function () {
    AutoInitAllDataTables();
});


function AdjustNoDataRowLeft() {
    var body = $(".dataTables_scrollBody")[0];
    var emptyRow = $(".dataTables_empty")[0];
    $(emptyRow).css('left', $(body).scrollLeft());
}

function AutoInitAllDataTables() {
    for (var i = 0; i < $(".table").length; i++) {

        var table = $(".table")[i];
        if (!$.fn.DataTable.isDataTable(table)) {

            DataTableInitialize(
                $(table),
                [
                    {
                        "targets": 0,
                        "searchable": false
                    }
                ],
                false
            );

        }


    };
}

// Call the dataTables jQuery plugin
function DataTableInitialize(table, defs, responsive) {

    //table = $(table).DataTable({
    //    //dom: 'Blfrtip',
    //    "lengthMenu": [[10, 25, 50, 100, 150, 200, - 1], [10, 25, 50, 100, 150, 200, "Hepsi"]],
    //    dom: "<'row'<'pt-1 col-sm-6 col-12'l><'pt-1 col-sm-6 col-12'f>>" + "<'row'<'col-sm-12'tr>>" + "<'row'<'d-flex justify-content-center col-12'i><'d-flex justify-content-center col-12'p><'pt-1 pb-1 col-sm-12 d-flex justify-content-center'B>>",
    //    buttons: [
    //        'copy', 'csv', 'excel', 'pdf', 'print'
    //    ],
    //    "iDisplayLength": 50,
    //    "iorder": [[0, "desc"]],
    //    "columnDefs": defs,
    //    "oLanguage": {
    //        "sUrl": "https://cdn.datatables.net/plug-ins/1.12.0/i18n/tr.json"
    //    },
    //    colReorder: true,
    //    //disable filter
    //    //"stateSaveParams": function (settings, data) {
    //    //    data.search.search = "";
    //    //},
    //    "oSearch": {
    //        "sSearch": ""
    //    },
    //    stateSave: true,
    //    responsive: responsive,
    //    "bAutowidth": false,
    //});

    var table = $(table).DataTable({
        "lengthMenu": [[10, 25, 50, 100, 150, 200, - 1], [10, 25, 50, 100, 150, 200, "Hepsi"]],
        "iDisplayLength": 50,
        "pageLength": 50,
        "order": [[0, "desc"]],
        "oLanguage": {
            "sUrl": "https://cdn.datatables.net/plug-ins/1.12.0/i18n/tr.json"
        },
        colReorder: true,
        stateSave: true,
        //disablefilter
        "stateSaveParams": function (settings, data) {
            data.search.search = "";
        },
        dom: "Q<'row'<'d-flex justify-content-center justify-content-sm-start pt-1 col-sm-6 col-12'l><'d-flex justify-content-center justify-content-sm-end pt-1 col-sm-6 col-12'f>> <'row'<'col-12'tr>> <'row'<'d-flex justify-content-center justify-content-lg-start col-12 col-lg-5'i><'d-flex justify-content-center justify-content-lg-end col-12 col-lg-7 p-2'p><'pt-1 pb-1 col-sm-12 d-flex justify-content-center'B>>",
        //dom: "QlftripB",
        "columnDefs": defs,

        buttons: [
            { extend: 'copy', className: 'btn-outline-primary' },
            { extend: 'csv', className: 'btn-outline-primary' },
            { extend: 'excel', className: 'btn-outline-primary' },
            { extend: 'pdf', className: 'btn-outline-primary' },
            { extend: 'print', className: 'btn-outline-primary' }
        ],
        responsive: responsive,
        "bAutowidth": false,
        fixedHeader: {
            header: true,
            footer: true
        },
        scrollX: true,
        scrollY: "57.54vh",
        //scrollCollapse: true,
        //scrollY: false
        "fnInitComplete": function () {
            //$('.dataTables_scrollBody').perfectScrollbar();
            //ps = new PerfectScrollbar('.dataTables_scrollBody');
            //$("thead tr").clone().appendTo($("tfoot"));
            $(".dataTables_scrollBody").scroll(function () {
                AdjustNoDataRowLeft();
            });
        },
        //on paginition page 2,3.. often scroll shown, so reset it and assign it again
        "fnDrawCallback": function (oSettings) {
            //$('.dataTables_scrollBody').perfectScrollbar('destroy').perfectScrollbar();
            //ps.update();
            //const ps = new PerfectScrollbar('.dataTables_scrollBody');
        }
    });



    table.search('');
    table.columns().search('');
    table.order([0, 'desc']);
    table.draw();

    //Burada T�rk�e karakter s�ralamas� yapt�m. Bu s�ralamay� kullanmak i�in ajax i�inde table tan�mlamas� �ncesi bu iki jquery oSort ve search yaz�lmas� gerekiyor.
    jQuery.extend(jQuery.fn.dataTableExt.oSort, {
        'locale-compare-asc': function (a, b) {
            return a.localeCompare(b, 'cs', { sensitivity: 'case' });
        },
        'locale-compare-desc': function (a, b) {
            return b.localeCompare(a, 'cs', { sensitivity: 'case' });
        }
    });


    jQuery.fn.dataTable.ext.type.search['locale-compare'] = function (data) {
        return NeutralizeAccent(data);
    };

    //Burada table global olmak zorundad�r. Aksi takdirde Neutralize komutu �al��mamaktad�r.




    //T�rk�e karakter arama sorunumuzu k�kten ��zen bir çöz�m.
    function NeutralizeAccent(data) {
        if (!data) {
            return "";
        }
        else if (typeof data === 'string') {
            //data = data.replace(/[iıİI]/g, 'İ').replace(/[Iı]/g, 'I');
            data = data.replace(/i/g, 'İ').replace(/ı/g, 'I');
            return data;
        }
        else {
            return data;
        }


    }
    $(document).on('keyup', "input[type='search']", function () {
        table.search(
            jQuery.fn.dataTable.ext.type.search.string(NeutralizeAccent(this.value))
        ).draw();
    });

    //$('<link>')
    //    .appendTo('head')
    //    .attr({
    //        type: 'text/css',
    //        rel: 'stylesheet',
    //        href: 'https://cdn.datatables.net/1.10.24/css/jquery.dataTables.min.css'
    //    });
    //$('<link>')
    //    .appendTo('head')
    //    .attr({
    //        type: 'text/css',
    //        rel: 'stylesheet',
    //        href: ' https://cdn.datatables.net/responsive/2.2.9/css/responsive.dataTables.min.css'
    //    });

}

