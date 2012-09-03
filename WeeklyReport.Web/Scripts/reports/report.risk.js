/// <reference path="../knockout-2.1.0.debug.js" />
/// <reference path="../jquery-1.7.2.js" />

Define("Report.Risk", {
    init: function (context, data) {

        function AppViewModel() {
            var self = this;

            self.Risks = ko.observableArray();
            for (var i = 0; i < data.length; i++) {
                self.Risks.push(new RiskItem(data[i]));
            }

            self.newLevel = ko.observable('');
            self.newDesc = ko.observable('');
            self.canAdd = ko.observable(false);

            self.addMore = function () {
                self.canAdd(!self.canAdd());
            };

            self.addNew = function () {
                if (self.newLevel().length > 0 && self.newDesc().length > 0) {
                    var newRisk = { Level: self.newLevel(), Description: self.newDesc() };
                    $.ajax({
                        url: '/wr/Risk/Create',
                        type: 'POST',
                        data: ko.utils.stringifyJson(newRisk),
                        contentType: 'application/json; charset=UTF-8',
                        success: function (response) {
                            if (!response.Success)
                                alert(response.Message);
                            else
                                self.Risks.push(new RiskItem(response.Data));

                            self.newLevel('').newDesc('').canAdd(false);
                        }
                    });
                }
            };

            self.deleteRisk = function (item) {
                var data = {
                    Id: item.Id,
                    Level: item.Level,
                    Description: item.Description
                };
                if (confirm('Do you want to delete item ' + item.Level + '?')) {
                    $.ajax({
                        url: '/wr/Risk/Delete',
                        type: 'POST',
                        data: ko.utils.stringifyJson(data),
                        contentType: 'application/json; charset=UTF-8',
                        success: function (response) {
                            if (response.Success)
                                self.Risks.remove(function (removedItem) { return removedItem.Id == data.Id; });
                        }
                    });
                };
            };
        }

        function RiskItem(item) {
            var self = this;
            self.Descriptive = ko.observable('Edit');
            self.Id = item.Id;
            self.Level = item.Level;
            self.Description = item.Description;
            self.EditMode = ko.observable(false);

            self.switchMode = function () {
                self.EditMode(!self.EditMode());
            };

            self.saveChanges = function () {
                var data = {
                    Id: item.Id,
                    Level: self.Level,
                    Description: self.Description
                };
                $.ajax({
                    url: '/wr/Risk/Save',
                    type: 'POST',
                    data: ko.utils.stringifyJson(data),
                    contentType: 'application/json; charset=UTF-8',
                    success: function (response) {
                        if (!response.Success)
                            alert(response.Message);
                        self.EditMode(false);
                    }
                });
            };
        }

        ko.applyBindings(new AppViewModel());
    },

    load: function (context) {
        $.ajax({
            url: Report.getUrl('wr/Risk/GetAll'),
            type: 'POST',
            data: {},
            //contentType: 'application/json; charset=UTF-8',
            success: function (response) {
                if (response.Success) {
                    Report.Risk.init(context, response.Data);
                }
            }
        });
    }
});