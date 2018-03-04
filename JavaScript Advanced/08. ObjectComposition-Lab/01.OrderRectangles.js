function orderRectangles(arr) {
    for (let i = 0; i < arr.length; i++) {
        arr[i] = {
            width: arr[i][0],
            height: arr[i][1],
            area: function () {
                return this.width * this.height
            },
            compareTo: function (other) {
                let diff = other.area() - this.area();
                return diff || other.width - this.width;
            }
        }
    }
    arr.sort((a, b) => a.compareTo(b));
    return arr;
}