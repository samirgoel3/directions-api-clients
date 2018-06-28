//
// SolutionAPI.swift
//
// Generated by openapi-generator
// https://openapi-generator.tech
//

import Foundation
import Alamofire



open class SolutionAPI {
    /**
     Return the solution associated to the jobId
     
     - parameter key: (query) your API key 
     - parameter jobId: (path) Request solution with jobId 
     - parameter completion: completion handler to receive the data and the error objects
     */
    open class func getSolution(key: String, jobId: String, completion: @escaping ((_ data: ModelResponse?,_ error: Error?) -> Void)) {
        getSolutionWithRequestBuilder(key: key, jobId: jobId).execute { (response, error) -> Void in
            completion(response?.body, error)
        }
    }


    /**
     Return the solution associated to the jobId
     - GET /vrp/solution/{jobId}
     - This endpoint returns the solution of a large problems. You can fetch it with the job_id, you have been sent. 
     - parameter key: (query) your API key 
     - parameter jobId: (path) Request solution with jobId 
     - returns: RequestBuilder<ModelResponse> 
     */
    open class func getSolutionWithRequestBuilder(key: String, jobId: String) -> RequestBuilder<ModelResponse> {
        var path = "/vrp/solution/{jobId}"
        let jobIdPreEscape = "\(jobId)"
        let jobIdPostEscape = jobIdPreEscape.addingPercentEncoding(withAllowedCharacters: .urlPathAllowed) ?? ""
        path = path.replacingOccurrences(of: "{jobId}", with: jobIdPostEscape, options: .literal, range: nil)
        let URLString = OpenAPIClientAPI.basePath + path
        let parameters: [String:Any]? = nil
        
        var url = URLComponents(string: URLString)
        url?.queryItems = APIHelper.mapValuesToQueryItems([
            "key": key
        ])

        let requestBuilder: RequestBuilder<ModelResponse>.Type = OpenAPIClientAPI.requestBuilderFactory.getBuilder()

        return requestBuilder.init(method: "GET", URLString: (url?.string ?? URLString), parameters: parameters, isBody: false)
    }

}