//
//  SwiftLibrary.swift
//  iosMauiSwiftLibrary
//
//  Created by Ocuvera on 7/18/24.
//

import Foundation
import UIKit

@objc(SwiftLibrary)
public class SwiftLibrary : NSObject{
    
    @objc
    public func returnString(input: String)->Int{
        //return "You gave me " + input;
        return 55; 
    }
}
