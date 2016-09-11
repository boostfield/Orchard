$(document).ready(function () {
    $.fn.select2.amd.require(['select2/compat/matcher'], function (oldMatcher) {
        $(".teacher-in-course").select2({

            placeholder: "教授该课程的老师",
            ajax: {
                url: "/api/manager/searchteacher",
                dataType: 'json',
                delay: 250,
                data: function (params) {
                    return {
                        keyword: params.term,
                        page: params.page,
                        pageSize: 20
                    };
                },
                processResults: function (data, params) {
                    params.page = params.page || 1;
                    var finalData = $.map(data.DataList, function (item) {
                        if (item.ENName.toUpperCase().indexOf(params.term.toUpperCase()) != -1) {
                            item.id = item.Id;
                            item.text = item.ENName + '<br>' + item.SN;
                            return item;
                        }
                    });
                    return {
                        results: finalData,
                        pagination: {
                            more: (params.page * 20) < data.TotalCount
                        }
                    };
                },
                cache: true
            },
            escapeMarkup: function (markup) { return markup; },
            minimumInputLength: 2,
            minimumResultsForSearch: Infinity,
            templateResult: formatRepo,
            templateSelection: formatRepoSelection,
            tags: false,
            matcher: oldMatcher(matchStart),
            multiple: true,
            allowClear: true,
            debug: true,
            closeOnSelect: true,

        });
        $(".teacher-paper").select2({

            placeholder: "相关论文",
            ajax: {
                url: "/api/manager/SearchAcademicPaper",
                dataType: 'json',
                delay: 250,
                data: function (params) {
                    return {
                        keyword: params.term,
                        page: params.page,
                        pageSize: 20
                    };
                },
                processResults: function (data, params) {
                    params.page = params.page || 1;
                    var finalData = $.map(data.DataList, function (item) {
                        if (item.Title.toUpperCase().indexOf(params.term.toUpperCase()) != -1) {
                            item.id = item.Id;
                            item.text = item.Title;
                            return item;
                        }
                    });
                    return {
                        results: finalData,
                        pagination: {
                            more: (params.page * 20) < data.TotalCount
                        }
                    };
                },
                cache: true
            },
            escapeMarkup: function (markup) { return markup; },
            minimumInputLength: 2,
            minimumResultsForSearch: Infinity,
            templateResult: formatRepo,
            templateSelection: formatRepoSelection,
            tags: false,
            matcher: oldMatcher(matchStart),
            multiple: true,
            allowClear: true,
            debug: true,
            closeOnSelect: true,

        });
        $(".teacher-work").select2({

            placeholder: "相关著作",
            ajax: {
                url: "/api/manager/SearchAcademicWork",
                dataType: 'json',
                delay: 250,
                data: function (params) {
                    return {
                        keyword: params.term,
                        page: params.page,
                        pageSize: 20
                    };
                },
                processResults: function (data, params) {
                    params.page = params.page || 1;
                    var finalData = $.map(data.DataList, function (item) {
                        if (item.Title.toUpperCase().indexOf(params.term.toUpperCase()) != -1) {
                            item.id = item.Id;
                            item.text = item.Title;
                            return item;
                        }
                    });
                    return {
                        results: finalData,
                        pagination: {
                            more: (params.page * 20) < data.TotalCount
                        }
                    };
                },
                cache: true
            },
            escapeMarkup: function (markup) { return markup; },
            minimumInputLength: 2,
            minimumResultsForSearch: Infinity,
            templateResult: formatRepo,
            templateSelection: formatRepoSelection,
            tags: false,
            matcher: oldMatcher(matchStart),
            multiple: true,
            allowClear: true,
            debug: true,
            closeOnSelect: true,

        });
        $(".teacher-award").select2({

            placeholder: "获奖成果",
            ajax: {
                url: "/api/manager/SearchAward",
                dataType: 'json',
                delay: 250,
                data: function (params) {
                    return {
                        keyword: params.term,
                        page: params.page,
                        pageSize: 20
                    };
                },
                processResults: function (data, params) {
                    params.page = params.page || 1;
                    var finalData = $.map(data.DataList, function (item) {
                        if (item.AwardName.toUpperCase().indexOf(params.term.toUpperCase()) != -1) {
                            item.id = item.Id;
                            item.text = item.AwardName;
                            return item;
                        }
                    });
                    return {
                        results: finalData,
                        pagination: {
                            more: (params.page * 20) < data.TotalCount
                        }
                    };
                },
                cache: true
            },
            escapeMarkup: function (markup) { return markup; },
            minimumInputLength: 2,
            minimumResultsForSearch: Infinity,
            templateResult: formatRepo,
            templateSelection: formatRepoSelection,
            tags: false,
            matcher: oldMatcher(matchStart),
            multiple: true,
            allowClear: true,
            debug: true,
            closeOnSelect: true,

        });
        $(".teacher-project").select2({

            placeholder: "承担课题",
            ajax: {
                url: "/api/manager/SearchProject",
                dataType: 'json',
                delay: 250,
                data: function (params) {
                    return {
                        keyword: params.term,
                        page: params.page,
                        pageSize: 20
                    };
                },
                processResults: function (data, params) {
                    params.page = params.page || 1;
                    var finalData = $.map(data.DataList, function (item) {
                        if (item.Title.toUpperCase().indexOf(params.term.toUpperCase()) != -1) {
                            item.id = item.Id;
                            item.text = item.Title;
                            return item;
                        }
                    });
                    return {
                        results: finalData,
                        pagination: {
                            more: (params.page * 20) < data.TotalCount
                        }
                    };
                },
                cache: true
            },
            escapeMarkup: function (markup) { return markup; },
            minimumInputLength: 2,
            minimumResultsForSearch: Infinity,
            templateResult: formatRepo,
            templateSelection: formatRepoSelection,
            tags: false,
            matcher: oldMatcher(matchStart),
            multiple: true,
            allowClear: true,
            debug: true,
            closeOnSelect: true,

        });
    });
});
function formatRepo(repo) {
    if (repo.loading) return repo.text;

    var markup =
        "<div class='select2-result-repository__title'>" + repo.text + "</div>";
    return markup;
}
function formatRepoSelection(repo) {
    return repo.text;
}
function matchStart(term, text) {
    return true;
    if (text.toUpperCase().indexOf(term.toUpperCase()) == 0) {
        return true;
    }

    return false;
}