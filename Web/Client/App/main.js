define(["App/one", "App/two", "App/three"], function (one, two, three) {
    "use strict";

    var inner = {};
    inner.Call = function () {
        one.Call();
        two.Call();
        three.Call();
    };
    return inner;
});