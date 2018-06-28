/**
 * GraphHopper Directions API
 * You use the GraphHopper Directions API to add route planning, navigation and route optimization to your software. E.g. the Routing API has turn instructions and elevation data and the Route Optimization API solves your logistic problems and supports various constraints like time window and capacity restrictions. Also it is possible to get all distances between all locations with our fast Matrix API.
 *
 * OpenAPI spec version: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


#include "OAITimeWindow.h"

#include "OAIHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace OpenAPI {

OAITimeWindow::OAITimeWindow(QString json) {
    init();
    this->fromJson(json);
}

OAITimeWindow::OAITimeWindow() {
    init();
}

OAITimeWindow::~OAITimeWindow() {
    this->cleanup();
}

void
OAITimeWindow::init() {
    earliest = 0L;
    m_earliest_isSet = false;
    latest = 0L;
    m_latest_isSet = false;
}

void
OAITimeWindow::cleanup() {


}

OAITimeWindow*
OAITimeWindow::fromJson(QString json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
OAITimeWindow::fromJsonObject(QJsonObject pJson) {
    ::OpenAPI::setValue(&earliest, pJson["earliest"], "qint64", "");
    
    ::OpenAPI::setValue(&latest, pJson["latest"], "qint64", "");
    
}

QString
OAITimeWindow::asJson ()
{
    QJsonObject obj = this->asJsonObject();
    QJsonDocument doc(obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject
OAITimeWindow::asJsonObject() {
    QJsonObject obj;
    if(m_earliest_isSet){
        obj.insert("earliest", QJsonValue(earliest));
    }
    if(m_latest_isSet){
        obj.insert("latest", QJsonValue(latest));
    }

    return obj;
}

qint64
OAITimeWindow::getEarliest() {
    return earliest;
}
void
OAITimeWindow::setEarliest(qint64 earliest) {
    this->earliest = earliest;
    this->m_earliest_isSet = true;
}

qint64
OAITimeWindow::getLatest() {
    return latest;
}
void
OAITimeWindow::setLatest(qint64 latest) {
    this->latest = latest;
    this->m_latest_isSet = true;
}


bool
OAITimeWindow::isSet(){
    bool isObjectUpdated = false;
    do{
        if(m_earliest_isSet){ isObjectUpdated = true; break;}
        if(m_latest_isSet){ isObjectUpdated = true; break;}
    }while(false);
    return isObjectUpdated;
}
}
