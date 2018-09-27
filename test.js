class Rectangle {
  constructor(height, width) {
    this.height = height;
    this.width = width;
    console.log( this.width);
  }
}

function test() {
  console.log("test");
  var test = new Rectangle(1,3);
}   