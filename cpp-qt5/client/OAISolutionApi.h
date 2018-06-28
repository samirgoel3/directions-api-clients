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

#ifndef _OAI_OAISolutionApi_H_
#define _OAI_OAISolutionApi_H_

#include "OAIHttpRequest.h"

#include "OAIOAIResponse.h"
#include <QString>

#include <QObject>

namespace OpenAPI {

class OAISolutionApi: public QObject {
    Q_OBJECT

public:
    OAISolutionApi();
    OAISolutionApi(QString host, QString basePath);
    ~OAISolutionApi();

    QString host;
    QString basePath;
    QMap<QString, QString> defaultHeaders;

    void getSolution(QString* key, QString* job_id);
    
private:
    void getSolutionCallback (OAIHttpRequestWorker * worker);
    
signals:
    void getSolutionSignal(OAIResponse* summary);
    
    void getSolutionSignalE(OAIResponse* summary, QNetworkReply::NetworkError error_type, QString& error_str);
    
    void getSolutionSignalEFull(OAIHttpRequestWorker* worker, QNetworkReply::NetworkError error_type, QString& error_str);
    
};

}
#endif