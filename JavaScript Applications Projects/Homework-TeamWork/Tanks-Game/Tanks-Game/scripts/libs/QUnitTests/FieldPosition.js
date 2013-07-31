﻿var GridPosition = Class.create({
    initialize: function (xCoord, yCoord) {
        this.xCoord = xCoord;
        this.yCoord = yCoord;
    },
    update: function (delta) {
        this.xCoord += delta.xCoord;
        this.yCoord += delta.yCoord;
    },
    equals: function (other) {
        return this.xCoord == other.xCoord && this.yCoord == other.yCoord;
    }
});