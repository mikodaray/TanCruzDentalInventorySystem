﻿$(function () {
    $.validator.methods.date = function (value, element) {
        return this.optional(element) || moment(value, "DD/MM/YYYY h:mm:ss a", true).isValid();
    };
});