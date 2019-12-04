﻿// <copyright file="GovUkBankHolidayJsonSourceTests.cs" company="Corsham Science">
// Copyright (c) Corsham Science. All rights reserved.
// </copyright>

namespace CorshamScience.Tools.WorkingDayService.Tests
{
    using System;
    using CorshamScience.Tools.WorkingDayService.HttpSource.GovUkJsonSource;
    using NUnit.Framework;

    /// <summary>
    /// Tests for the Parse method for the GovUkBankHolidayJson implementation of the HttpSource.
    /// </summary>
    [TestFixture]
    public class GovUkBankHolidayJsonSourceTests
    {
        /// <summary>
        /// A test to ensure the GovUkBankHolidayJsonParse method parses correctly.
        /// </summary>
        [Test]
        public static void GovUkBankHolidayJsonParseParsesCorrectly()
        {
            var result = GovUkBankHolidayJsonSourceExtensions.GovUkBankHolidayJsonParse("{\"england-and-wales\":{\"division\":\"england-and-wales\",\"events\":[{\"title\":\"New Year\u2019s Day\",\"date\":\"2012-01-02\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2012-04-06\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Easter Monday\",\"date\":\"2012-04-09\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Early May bank holiday\",\"date\":\"2012-05-07\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2012-06-04\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"Queen\u2019s Diamond Jubilee\",\"date\":\"2012-06-05\",\"notes\":\"Extra bank holiday\",\"bunting\":true},{\"title\":\"Summer bank holiday\",\"date\":\"2012-08-27\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2012-12-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2012-12-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2013-01-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2013-03-29\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Easter Monday\",\"date\":\"2013-04-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Early May bank holiday\",\"date\":\"2013-05-06\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2013-05-27\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Summer bank holiday\",\"date\":\"2013-08-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2013-12-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2013-12-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2014-01-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2014-04-18\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Easter Monday\",\"date\":\"2014-04-21\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Early May bank holiday\",\"date\":\"2014-05-05\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2014-05-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Summer bank holiday\",\"date\":\"2014-08-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2014-12-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2014-12-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2015-01-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2015-04-03\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Easter Monday\",\"date\":\"2015-04-06\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Early May bank holiday\",\"date\":\"2015-05-04\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2015-05-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Summer bank holiday\",\"date\":\"2015-08-31\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2015-12-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2015-12-28\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2016-01-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2016-03-25\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Easter Monday\",\"date\":\"2016-03-28\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Early May bank holiday\",\"date\":\"2016-05-02\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2016-05-30\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Summer bank holiday\",\"date\":\"2016-08-29\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2016-12-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2016-12-27\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2017-01-02\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2017-04-14\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Easter Monday\",\"date\":\"2017-04-17\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Early May bank holiday\",\"date\":\"2017-05-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2017-05-29\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Summer bank holiday\",\"date\":\"2017-08-28\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2017-12-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2017-12-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2018-01-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2018-03-30\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Easter Monday\",\"date\":\"2018-04-02\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Early May bank holiday\",\"date\":\"2018-05-07\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2018-05-28\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Summer bank holiday\",\"date\":\"2018-08-27\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2018-12-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2018-12-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2019-01-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2019-04-19\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Easter Monday\",\"date\":\"2019-04-22\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Early May bank holiday\",\"date\":\"2019-05-06\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2019-05-27\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Summer bank holiday\",\"date\":\"2019-08-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2019-12-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2019-12-26\",\"notes\":\"\",\"bunting\":true}]},\"scotland\":{\"division\":\"scotland\",\"events\":[{\"title\":\"2nd January\",\"date\":\"2012-01-02\",\"notes\":\"\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2012-01-03\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2012-04-06\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Early May bank holiday\",\"date\":\"2012-05-07\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2012-06-04\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"Queen\u2019s Diamond Jubilee\",\"date\":\"2012-06-05\",\"notes\":\"Extra bank holiday\",\"bunting\":true},{\"title\":\"Summer bank holiday\",\"date\":\"2012-08-06\",\"notes\":\"\",\"bunting\":true},{\"title\":\"St Andrew\u2019s Day\",\"date\":\"2012-11-30\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2012-12-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2012-12-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2013-01-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"2nd January\",\"date\":\"2013-01-02\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2013-03-29\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Early May bank holiday\",\"date\":\"2013-05-06\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2013-05-27\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Summer bank holiday\",\"date\":\"2013-08-05\",\"notes\":\"\",\"bunting\":true},{\"title\":\"St Andrew\u2019s Day\",\"date\":\"2013-12-02\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2013-12-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2013-12-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2014-01-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"2nd January\",\"date\":\"2014-01-02\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2014-04-18\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Early May bank holiday\",\"date\":\"2014-05-05\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2014-05-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Summer bank holiday\",\"date\":\"2014-08-04\",\"notes\":\"\",\"bunting\":true},{\"title\":\"St Andrew\u2019s Day\",\"date\":\"2014-12-01\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2014-12-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2014-12-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2015-01-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"2nd January\",\"date\":\"2015-01-02\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2015-04-03\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Early May bank holiday\",\"date\":\"2015-05-04\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2015-05-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Summer bank holiday\",\"date\":\"2015-08-03\",\"notes\":\"\",\"bunting\":true},{\"title\":\"St Andrew\u2019s Day\",\"date\":\"2015-11-30\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2015-12-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2015-12-28\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2016-01-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"2nd January\",\"date\":\"2016-01-04\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2016-03-25\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Early May bank holiday\",\"date\":\"2016-05-02\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2016-05-30\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Summer bank holiday\",\"date\":\"2016-08-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"St Andrew\u2019s Day\",\"date\":\"2016-11-30\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2016-12-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2016-12-27\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"2nd January\",\"date\":\"2017-01-02\",\"notes\":\"\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2017-01-03\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2017-04-14\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Early May bank holiday\",\"date\":\"2017-05-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2017-05-29\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Summer bank holiday\",\"date\":\"2017-08-07\",\"notes\":\"\",\"bunting\":true},{\"title\":\"St Andrew\u2019s Day\",\"date\":\"2017-11-30\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2017-12-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2017-12-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2018-01-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"2nd January\",\"date\":\"2018-01-02\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2018-03-30\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Early May bank holiday\",\"date\":\"2018-05-07\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2018-05-28\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Summer bank holiday\",\"date\":\"2018-08-06\",\"notes\":\"\",\"bunting\":true},{\"title\":\"St Andrew\u2019s Day\",\"date\":\"2018-11-30\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2018-12-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2018-12-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2019-01-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"2nd January\",\"date\":\"2019-01-02\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2019-04-19\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Early May bank holiday\",\"date\":\"2019-05-06\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2019-05-27\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Summer bank holiday\",\"date\":\"2019-08-05\",\"notes\":\"\",\"bunting\":true},{\"title\":\"St Andrew\u2019s Day\",\"date\":\"2019-12-02\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2019-12-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2019-12-26\",\"notes\":\"\",\"bunting\":true}]},\"northern-ireland\":{\"division\":\"northern-ireland\",\"events\":[{\"title\":\"New Year\u2019s Day\",\"date\":\"2012-01-02\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"St Patrick\u2019s Day\",\"date\":\"2012-03-19\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2012-04-06\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Easter Monday\",\"date\":\"2012-04-09\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Early May bank holiday\",\"date\":\"2012-05-07\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2012-06-04\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Queen\u2019s Diamond Jubilee\",\"date\":\"2012-06-05\",\"notes\":\"Extra bank holiday\",\"bunting\":true},{\"title\":\"Battle of the Boyne (Orangemen\u2019s Day)\",\"date\":\"2012-07-12\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Summer bank holiday\",\"date\":\"2012-08-27\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2012-12-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2012-12-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2013-01-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"St Patrick\u2019s Day\",\"date\":\"2013-03-18\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2013-03-29\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Easter Monday\",\"date\":\"2013-04-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Early May bank holiday\",\"date\":\"2013-05-06\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2013-05-27\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Battle of the Boyne (Orangemen\u2019s Day)\",\"date\":\"2013-07-12\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Summer bank holiday\",\"date\":\"2013-08-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2013-12-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2013-12-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2014-01-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"St Patrick\u2019s Day\",\"date\":\"2014-03-17\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2014-04-18\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Easter Monday\",\"date\":\"2014-04-21\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Early May bank holiday\",\"date\":\"2014-05-05\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2014-05-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Battle of the Boyne (Orangemen\u2019s Day)\",\"date\":\"2014-07-14\",\"notes\":\"Substitute day\",\"bunting\":false},{\"title\":\"Summer bank holiday\",\"date\":\"2014-08-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2014-12-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2014-12-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2015-01-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"St Patrick\u2019s Day\",\"date\":\"2015-03-17\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2015-04-03\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Easter Monday\",\"date\":\"2015-04-06\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Early May bank holiday\",\"date\":\"2015-05-04\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2015-05-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Battle of the Boyne (Orangemen\u2019s Day)\",\"date\":\"2015-07-13\",\"notes\":\"Substitute day\",\"bunting\":false},{\"title\":\"Summer bank holiday\",\"date\":\"2015-08-31\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2015-12-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2015-12-28\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2016-01-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"St Patrick\u2019s Day\",\"date\":\"2016-03-17\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2016-03-25\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Easter Monday\",\"date\":\"2016-03-28\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Early May bank holiday\",\"date\":\"2016-05-02\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2016-05-30\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Battle of the Boyne (Orangemen\u2019s Day)\",\"date\":\"2016-07-12\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Summer bank holiday\",\"date\":\"2016-08-29\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2016-12-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2016-12-27\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2017-01-02\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"St Patrick\u2019s Day\",\"date\":\"2017-03-17\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2017-04-14\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Easter Monday\",\"date\":\"2017-04-17\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Early May bank holiday\",\"date\":\"2017-05-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2017-05-29\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Battle of the Boyne (Orangemen\u2019s Day)\",\"date\":\"2017-07-12\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Summer bank holiday\",\"date\":\"2017-08-28\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2017-12-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2017-12-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2018-01-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"St Patrick\u2019s Day\",\"date\":\"2018-03-19\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2018-03-30\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Easter Monday\",\"date\":\"2018-04-02\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Early May bank holiday\",\"date\":\"2018-05-07\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2018-05-28\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Battle of the Boyne (Orangemen\u2019s Day)\",\"date\":\"2018-07-12\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Summer bank holiday\",\"date\":\"2018-08-27\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2018-12-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2018-12-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"New Year\u2019s Day\",\"date\":\"2019-01-01\",\"notes\":\"\",\"bunting\":true},{\"title\":\"St Patrick\u2019s Day\",\"date\":\"2019-03-18\",\"notes\":\"Substitute day\",\"bunting\":true},{\"title\":\"Good Friday\",\"date\":\"2019-04-19\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Easter Monday\",\"date\":\"2019-04-22\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Early May bank holiday\",\"date\":\"2019-05-06\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Spring bank holiday\",\"date\":\"2019-05-27\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Battle of the Boyne (Orangemen\u2019s Day)\",\"date\":\"2019-07-12\",\"notes\":\"\",\"bunting\":false},{\"title\":\"Summer bank holiday\",\"date\":\"2019-08-26\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Christmas Day\",\"date\":\"2019-12-25\",\"notes\":\"\",\"bunting\":true},{\"title\":\"Boxing Day\",\"date\":\"2019-12-26\",\"notes\":\"\",\"bunting\":true}]}}");

            Assert.IsFalse(result == null);
            Assert.AreEqual(65, result.Count);
            Assert.IsTrue(result.Contains(new DateTime(2018, 12, 25)));
        }
    }
}
