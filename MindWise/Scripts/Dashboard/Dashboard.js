$(function() {
    tblCVVLDG();
   tblDUMPSLDG();
    $("#btnSearchCVVLDG").on("click", function() {
        tblCVVLDG();
    });
$("#btnSearchDUMPSLDG").on("click", function() {
        tblDUMPSLDG();
    });
});

function tblCVVLDG() {
    $("#tblCVVLDG").dataTable({
        "bServerSide": true,
        "bProcessing": true,
        "bFilter": false,
        "bSort": false,
        "destroy": true,
        "bLengthChange": false,
        //"sDom": '<"top"<"actions">lfpi<"clear">><"clear">rt<"bottom">',
        "bInfo": true,
        responsive: true,
        "sServerMethod": "POST",
        sAjaxSource: "/Dashboard/GetCVVLDG",
        "fnServerData": function(sSource, aoData, fnCallback) {
            aoData.push({
                "name": "serchByName",
                "value": $("#txtSearchbyUsername").val()
            });
            aoData.push({
                "name": "searchByBin",
                "value": $("#txtSearchbyBin").val()
            });
            $.getJSON(sSource, aoData, function(json) {
                fnCallback(json);
            });
        },

        "oLanguage": {
            "oPaginate": {
                "sFirst": "<<", // This is the link to the first page
                "sPrevious": "<", // This is the link to the previous page
                "sNext": ">", // This is the link to the next page
                "sLast": ">>" // This is the link to the last page
            }
        },
        "order": [
            [0, "desc"]
        ],
        "iDisplayLength": 10,
        "sPaginationType": "full_numbers",
        "aoColumns": [{
                "aTargets": [0],
                "sName": "Bin",
                "mRender": function(data, type, row) {
                    return row[1];
                }
            },
            {
                "aTargets": [1],
                "mData": "UserName",
                "mRender": function(data, type, row) {
                    return row[0];
                }
            },
            {
                "aTargets": [2],
                "mData": "Bank",
                "mRender": function(data, type, row) {
                    return row[2];
                }
            },
            {
                "aTargets": [3],
                "mData": "CardClass",
                "mRender": function(data, type, row) {
                    return row[3];
                }
            },
            {
                "aTargets": [4],
                "mData": "State",
                "mRender": function(data, type, row) {
                    return row[4];
                }
            }, {
                "aTargets": [5],
                "mData": "City",
                "mRender": function(data, type, row) {
                    return row[5];
                }
            },
            {
                "mData": "Action",
                "orderable": false,
                "mRender": function(data, type, row) {
                    return "<a href='#'><button type='button' class='btn btn-xs btn-success'>Buy</button></a>";
                }
            }
        ]
    });
}

function tblDUMPSLDG() {
    $("#tblDUMPSLDG").dataTable({
        "bServerSide": true,
        "bProcessing": true,
        "bFilter": false,
        "bSort": false,
        "destroy": true,
        "bLengthChange": false,
        //"sDom": '<"top"<"actions">lfpi<"clear">><"clear">rt<"bottom">',
        "bInfo": true,
        responsive: true,
        "sServerMethod": "POST",
        sAjaxSource: "/Dashboard/GetDUMPSLDG",
        "fnServerData": function(sSource, aoData, fnCallback) {
            aoData.push({
                "name": "searchByBin",
                "value": $("#txtSearchDUMPSLDGbyBin").val()
            });
            $.getJSON(sSource, aoData, function(json) {
                fnCallback(json);
            });
        },

        "oLanguage": {
            "oPaginate": {
                "sFirst": "<<", // This is the link to the first page
                "sPrevious": "<", // This is the link to the previous page
                "sNext": ">", // This is the link to the next page
                "sLast": ">>" // This is the link to the last page
            }
        },
        "order": [
            [0, "desc"]
        ],
        "iDisplayLength": 10,
        "sPaginationType": "full_numbers",
        "aoColumns": [{
                "aTargets": [0],
                "sName": "Bin",
                "mRender": function(data, type, row) {
                    return row[0];
                }
            },
            {
                "aTargets": [1],
                "mData": "Tracks",
                "mRender": function(data, type, row) {
                    return row[1];
                }
            },
            {
                "aTargets": [2],
                "mData": "TrackType",
                "mRender": function(data, type, row) {
                    return row[2];
                }
            },
            {
                "aTargets": [3],
                "mData": "Bank",
                "mRender": function(data, type, row) {
                    return row[3];
                }
            },
            {
                "aTargets": [4],
                "mData": "CardClass",
                "mRender": function(data, type, row) {
                    return row[4];
                }
            }, {
                "aTargets": [5],
                "mData": "State",
                "mRender": function(data, type, row) {
                    return row[5];
                }
            },
{
                "aTargets": [6],
                "mData": "City",
                "mRender": function(data, type, row) {
                    return row[6];
                }
            },
            {
                "mData": "Action",
                "orderable": false,
                "mRender": function(data, type, row) {
                    return "<a href='#'><button type='button' class='btn btn-xs btn-success'>Buy</button></a>";
                }
            }
        ]
    });
}