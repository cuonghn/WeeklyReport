/// <reference path="../jquery-1.7.2.js" />

$.extend(true, window, {
    Define: function (namespace, dict) {
        var mems = namespace.split('.');
        var map = window;

        for (var i = 0; i < mems.length; i++) {
            if (map[mems[i]] == null)
                map[mems[i]] = {};

            map = map[mems[i]];
        }

        return $.extend(true, map, dict);
    }
});

Define('Report', {
    getUrl: function (path) {
        var root = $('#Root').val();
        return root + path;
    }
});