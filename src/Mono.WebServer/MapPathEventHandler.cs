//
// Mono.WebServer.MapPathEventHandler
//
// Authors:
//	Daniel Lopez Ridruejo
// 	Gonzalo Paniagua Javier
//
// Documentation:
//	Brian Nickel
//
// Copyright (c) 2002 Daniel Lopez Ridruejo.
//           (c) 2002,2003 Ximian, Inc.
//           All rights reserved.
// (C) Copyright 2004-2010 Novell, Inc. (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;

namespace Mono.WebServer
{
	/// <summary>
	///    This delegate is used to handle <see
	///    cref="MonoWorkerRequest.MapPathEvent" /> and performs custom path
	///    mapping.
	/// </summary>
	/// <param name="sender">
	///    The <see cref="object" /> that sent the event.
	/// </param>
	/// <param name="args">
	///    A <see cref="MapPathEventArgs" /> object containing the arguments
	///    for the event.
	/// </param>
	/// <remarks>
	///    This method is used for custom path mapping within <see
	///    cref="MonoWorkerRequest.MapPath" />.
	/// </remarks>
	/// <example>
	///    An example <see cref="MapPathEventHandler" />
	///    <code language="C#">
	///        void OnMapPathEvent (object sender, MapPathEventArgs args)
	///        {
	///            if (args.Path.StartsWith ("/blog"))
	///                args.MappedPath = @"C:\Documents and Settings\John Doe\My Documents\Visual Studio 2005\WebSites\blog";
	///        }
	///    </code>
	/// </example>
	public delegate void MapPathEventHandler (object sender, MapPathEventArgs args);
}
