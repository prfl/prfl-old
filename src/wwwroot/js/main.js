

window.setVisitor = (obj) => {
    //let device = {'deviceId': obj.deviceId, 'createdOn': obj.createdOn, 'page': obj.page };
    localStorage.setItem("prfl-visitorId", obj.visitorId);
    localStorage.setItem("prfl-visitedOn", obj.visitedOn);
    localStorage.setItem("prfl-page", obj.page);
};


function SetTitle(title) {
    document.title = title;
}